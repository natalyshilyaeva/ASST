using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Dll
{
    public abstract class AbsFactory : Component
    {//абс фабрика - фабрики создают продукт Food и связанный по смыслу с Food продукт Window
        public abstract Food CreateFood();
        public abstract Form CreateWindow(Food food);
        //для доступа к полям видов еды, форма должна знать о своих видах
    }
    public class PFactory : AbsFactory
    {//создаёт продукт Pizza..
        public override Food CreateFood()
        {
            return new Cheese();
        }
        public override Form CreateWindow(Food food)
        {//в параметрах передаём ссылку на связанную еду
            return new Pizza(food);
        }
    }//end Pizza
    public class SFactory : AbsFactory
    {//создаёт продукт Sushi..
        public override Food CreateFood()
        {
            return new Rolls();
        }
        public override Form CreateWindow(Food food)
        {
            return new Sushi(food);
        }
    }//end Sushi

    public abstract class Food
    {//какая-то еда
        protected string size;//есть размер
        protected string weight;//есть вес
        public string Size { get { return this.size; } }//свойства (геттер)
        public string Weight { get { return this.weight; } }//свойства (геттер)
        public abstract string Info();//некоторая историческая справка
    }
    public class Cheese : Food
    {
        public Cheese()
        {
            this.size = "Диаметр = 30 см";
            this.weight = "(600-700) гр";
        }
        public override string Info()
        {
            return @"Само название «пицца» произошло от греческого слова «пита», что означает пирог. Изначально пицца была едой бедняков-простолюдинов. Это они, обычные работяги, придумали быстрый в приготовлении, легкий и вкусный рецепт: кусочек теста округлой формы с разнообразной начинкой сверху и обязательно покрытою сыром. Но привычная нам классическая пицца появилась в итальянском городе Неаполь в 16 веке. В 1552 году в Европу завезли томаты и бедняки стали добавлять их в свои лепешки, так и появилась на свет первая неаполитанская пицца.";
        }
    }
    public class Rolls : Food
    {
        public Rolls()
        {
            this.size = "Диаметр = 40 мм";
            this.weight = "(200-300) гр";
        }
        public override string Info()
        {
            return @"Считается, что впервые сырую рыбу и рис японцы соединили для того, чтобы хранить рыбу, и произошло это в 6 столетии нашей эры. В конце 17 века с ростом производства риса из него стали готовить рисовый уксус, который в свою очередь начали добавлять в рис, а рыбу и морепродукты с таким рисом начали подавать в сыром виде. Суши в современном виде появились не так давно — в 19 веке в городе Эдо (Токио).";
        }
    }
}
