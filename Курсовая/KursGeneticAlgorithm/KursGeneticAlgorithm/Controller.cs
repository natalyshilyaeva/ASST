using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursGeneticAlgorithm
{
    public class Controller
    {
        //ссылки на вид и модель
        private GeneticAlgorithm model;
        private Form1 view;
        //конструктор
        public Controller(GeneticAlgorithm model, Form1 view)
        {
            this.model = model;
            this.view = view;
        }
        //передача данных
        public void SetData(double XoverRate, double mutRate, int popSize, int genSize, int ChromLength)
        {
            model.CrossoverRate = XoverRate;
            model.MutationRate = mutRate;
            model.PopulationSize = popSize;
            model.GenerationSize = genSize;
            model.ChromosomeLength = ChromLength;
        }
        //включение модели
        public async Task SwitchOn() { model.SwitchedOn = true; await Task.Delay(1000); }
        //выключение модели
        public async Task SwitchOff() { model.SwitchedOn = false; await Task.Delay(1000); }
    }
}
