using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursGeneticAlgorithm
{
    //наблюдатель
    public interface IObserver
    {
        Task UpdateState();
    }
}
