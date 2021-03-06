using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursGeneticAlgorithm
{
    public sealed class Chromosome 
    {
        private static Random rand = new Random();      //случайное число
        public double[] ChromosomeGenes { set; get; }   //массив генов
        public int ChromosomeLength { set; get; }       //кол-во генов
        public double ChromosomeFitness { set; get; }   //коэффициент приспособленности хромосомы
                                                        
        public static double ChromosomeMutationRate;    //процент мутации
        //конструктор
        public Chromosome(int length, bool createGenes)
        {
            ChromosomeLength = length;
            ChromosomeGenes = new double[length];
            //создание случайных генов
            if (createGenes)
            {
                for (int i = 0; i < ChromosomeLength; i++)
                    ChromosomeGenes[i] = rand.NextDouble() * 10;
            }
        }
        //кроссовер
        public void Crossover(ref Chromosome Chromosome2, out Chromosome child1, out Chromosome child2)
        {
            int position = (int)(rand.NextDouble() * 10 * (double)ChromosomeLength);
            child1 = new Chromosome(ChromosomeLength, false);
            child2 = new Chromosome(ChromosomeLength, false);
            //перекрещивание генов и создание потомков с новым геномом
            for (int i = 0; i < ChromosomeLength; i++)
            {
                if (i < position)
                {
                    child1.ChromosomeGenes[i] = ChromosomeGenes[i];
                    child2.ChromosomeGenes[i] = Chromosome2.ChromosomeGenes[i];
                }
                else
                {
                    child1.ChromosomeGenes[i] = Chromosome2.ChromosomeGenes[i];
                    child2.ChromosomeGenes[i] = ChromosomeGenes[i];
                }
            }
        }
        //мутация
        public void Mutate()
        {
            for (int position = 0; position < ChromosomeLength; position++)
            {
                if (rand.NextDouble() < ChromosomeMutationRate)
                    ChromosomeGenes[position] = (ChromosomeGenes[position] + rand.NextDouble() * 10) / 2.0;
            }
        }
        //извлечение генов
        public void ExtractChromosomeValues(ref double[] values)
        {
            for (int i = 0; i < ChromosomeLength; i++)
                values[i] = ChromosomeGenes[i];
        }
    }
}
