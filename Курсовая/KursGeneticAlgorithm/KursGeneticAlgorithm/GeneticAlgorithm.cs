using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace KursGeneticAlgorithm
{
    public class GeneticAlgorithm
    {
        public bool SwitchedOn { set; get; }        //включение-выключение

        private static Random rand = new Random();  //случайное число
        public double MutationRate;                 //процент мутации
        public double CrossoverRate;                //процент кроссовера
        public int ChromosomeLength;                //кол-во генов
        public int PopulationSize;                  //размер популяции
        public int GenerationSize;                  //кол-во поколений
        public double TotalFitness;                 //текущая приспособленность
        public bool Elitism;                        //элитизм

        private ArrayList CurrentGenerationList;    //массив текущего поколения
        private ArrayList NextGenerationList;       //массив следующего поколения
        private ArrayList FitnessList;              //массив приспособленности

        static private GAFunction getFitness;       //делегат функции

        public GAFunction FitnessFunction           //атрибут доступа к функции
        {
            get { return getFitness; }
            set { getFitness = value; }
        }
                                                    //список зарегистрированных видов
        private ArrayList listeners = new ArrayList();
        //конструктор
        public GeneticAlgorithm()
        {
            Elitism = false;
            SwitchedOn = false;
            MutationRate = 0.05;
            CrossoverRate = 0.8;
            PopulationSize = 100;
            GenerationSize = 2000;
            ChromosomeLength = 2;
        }
        //работа алгоритма
        //async - асинхронизация процессов
        public async Task LaunchGA()
        {
            FitnessList = new ArrayList();
            CurrentGenerationList = new ArrayList(GenerationSize);
            NextGenerationList = new ArrayList(GenerationSize);
            Chromosome.ChromosomeMutationRate = MutationRate;
            //создание популяции
            for (int i = 0; i < PopulationSize; i++)
            {
                Chromosome g = new Chromosome(ChromosomeLength, true);
                CurrentGenerationList.Add(g);
            }
            
            RankPopulation();
            //проход по всем поколениям
            for (int i = 0; i < GenerationSize; i++)
            {
                if (i % 100 == 0 || (i + 1) == GenerationSize)
                {
                    //await - ожидание окончания данного процесса
                    await UpdateObservers();
                }
                CreateNextGeneration();
                RankPopulation();
            }
        }
        //выборка особей
        private int RouletteSelection()
        {
            //случайный коэффициент приспособленности
            double randomFitness = rand.NextDouble() * TotalFitness;
            //двоичный поиск для выборки
            int idx = -1;
            int mid;
            int first = 0;
            int last = PopulationSize - 1;
            mid = (last - first) / 2;
            while (idx == -1 && first <= last)
            {
                if (randomFitness < (double)FitnessList[mid])
                { last = mid; }
                else if (randomFitness > (double)FitnessList[mid])
                { first = mid; }
                mid = (first + last) / 2;
                if ((last - first) == 1) idx = last;
            }
            return idx;
        }
        //классификация популяции
        private void RankPopulation()
        {
            TotalFitness = 0;
            //текущая приспособленность
            for (int i = 0; i < PopulationSize; i++)
            {
                Chromosome g = ((Chromosome)CurrentGenerationList[i]);
                g.ChromosomeFitness = FitnessFunction(g.ChromosomeGenes);
                TotalFitness += g.ChromosomeFitness;
            }
            //сортировка текущего поколения
            CurrentGenerationList.Sort(new ChromosomeComparer());
            double fitness = 0.0;
            FitnessList.Clear();
            //вычисление приспособленности для каждой особи
            for (int i = 0; i < PopulationSize; i++)
            {
                fitness += ((Chromosome)CurrentGenerationList[i]).ChromosomeFitness;
                FitnessList.Add((double)fitness);
            }
        }
        //создание следующего поколения
        private void CreateNextGeneration()
        {
            NextGenerationList.Clear();
            Chromosome g = null;
            if (Elitism)
                g = (Chromosome)CurrentGenerationList[PopulationSize - 1];
            //выборка, кроссовер или мутация, добавление потомков в следующее поколение
            for (int i = 0; i < PopulationSize; i += 2)
            {
                int pidx1 = RouletteSelection();
                int pidx2 = RouletteSelection();
                Chromosome parent1, parent2, child1, child2;
                parent1 = ((Chromosome)CurrentGenerationList[pidx1]);
                parent2 = ((Chromosome)CurrentGenerationList[pidx2]);

                if (rand.NextDouble() < CrossoverRate)
                { parent1.Crossover(ref parent2, out child1, out child2); }
                else
                {
                    child1 = parent1;
                    child2 = parent2;
                }
                child1.Mutate();
                child2.Mutate();
                NextGenerationList.Add(child1);
                NextGenerationList.Add(child2);
            }
            if (Elitism && g != null) NextGenerationList[0] = g;
            CurrentGenerationList.Clear();
            for (int i = 0; i < PopulationSize; i++)
                CurrentGenerationList.Add(NextGenerationList[i]);
        }
        //получение лучших генов
        public void GetBestValues(out double[] values, out double fitness)
        {
            Chromosome g = ((Chromosome)CurrentGenerationList[PopulationSize - 1]);
            values = new double[g.ChromosomeLength];
            g.ExtractChromosomeValues(ref values);
            fitness = (double)g.ChromosomeFitness;
        }
        //обновление видов
        public async Task UpdateObservers()
        {
            foreach (IObserver ob in listeners)
            {
                await ob.UpdateState();
            }
        }
        //регистрация видов
        public void Register(IObserver o)
        {
            listeners.Add(o);
        }
        //дерегистрация видов
        public void Deregister(IObserver o)
        {
            listeners.Remove(o);
        }
    }
}
