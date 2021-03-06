using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursGeneticAlgorithm
{
    public partial class EnglishInformation : Form
    {
        //ссылка на продукт
        private AbstractProduct english;
        //конструктор
        public EnglishInformation(AbstractProduct english)
        {
            InitializeComponent();
            this.english = english;
            richTextBox1.Text = english.Information();
        }
        //перевод
        private void translate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("        ПЕРЕВОД\n" +
                            "Элитарность проста: мы используем Генетический алгоритм, чтобы напрямую ввести в численность следующей популяции наиболее устойчивую(-ых) особей из предыдущей популяции. Эти особи называются элитами. Сохраняя лучших особей (или индивидов) для будущих популяций, этот алгоритм начинает напоминать(µ + l) и обладает аналогичными эксплуатационными свойствами. Эта эксплуатация может вызвать преждевременную конвергенцию, если ее не сдерживать: возможно, путем увеличения мутации и кроссовера, или ослабления селекции, или уменьшения того, сколько элит сохранится. Напоследок. Если вы хотите сохранить размер численности популяции, и вы совершаете кроссовер, вы должны иметь размер популяции минус количество элит, например две, как в данном алгоритме: ");
        }
    }
}
