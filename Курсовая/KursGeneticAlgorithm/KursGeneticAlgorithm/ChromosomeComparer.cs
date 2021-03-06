using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace KursGeneticAlgorithm
{
    //класс сравнения хромосом
    public sealed class ChromosomeComparer : IComparer
    {
        //сравнение
        public int Compare(object x, object y)
        {
            if (!(x is Chromosome) || !(y is Chromosome))
                throw new ArgumentException("Not of type Chromosome");
            //сравнение коэффициентов приспособленности
            if (((Chromosome)x).ChromosomeFitness > ((Chromosome)y).ChromosomeFitness)
                return 1;
            else if (((Chromosome)x).ChromosomeFitness == ((Chromosome)y).ChromosomeFitness)
                return 0;
            else
                return -1;
        }
    }
}
