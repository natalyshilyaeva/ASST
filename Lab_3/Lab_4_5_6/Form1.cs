using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_5_6
{
    public partial class Form1 : Form
    {
        ArrayList list;
        public Form1()
        {
            InitializeComponent();

            list = new ArrayList();
        }

        private void RadioButton_Repair_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
            textBox3.Enabled = false;
            textBox4.Enabled = false;            
        }

        private void RadioButton_Intercom_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }

        private void Button_Baza_Click(object sender, EventArgs e)
        {
            if (radioButton_Repair.Checked)
            {
                var repair = new Repair_Pay(comboBox_Surname.Text,
                    (int)numericUpDown1.Value);
                list.Add(repair);
                listBox_Home.Items.Add(repair.Info());
            }
            else if (radioButton_Intercom.Checked)
            {
                try
                {
                    var intercom = new Intercom_Pay(comboBox_Surname.Text,
                    int.Parse(textBox3.Text),
                    int.Parse(textBox4.Text));
                    list.Add(intercom);
                    listBox_Home.Items.Add(intercom.Info());
                }
                catch (FormatException)
                {
                    MessageBox.Show("Неверные данные!");
                }

            }            
        }

        private void Button_Filter_Click(object sender, EventArgs e)
        {
            listBox_Filter.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                var pay = (Pay)list[i];
                if (checkBox_Intercom.Checked && (pay as Intercom_Pay) != null
                    || checkBox_Repair.Checked && (pay as Repair_Pay) != null)
                {
                    listBox_Filter.Items.Add(pay.Info());
                }
            }
        }

        private void Button_Sum_Click(object sender, EventArgs e)
        {
            double sum = 0;
            foreach (Pay pay in list)
            {
                sum += pay.Sum();
            }
            textBox_Sum.Text = sum.ToString();
        }

        private void Button_Surname_Click(object sender, EventArgs e)
        {
            if (comboBox_Surname.Text.Length > 0
            && !comboBox_Surname.Items.Contains(comboBox_Surname.Text))
            {
                comboBox_Surname.Items.Add(comboBox_Surname.Text);
            }
        }

        private void TrackBar_Filter_Scroll(object sender, EventArgs e)
        {
            listBox_Filter.Font = new Font("New", trackBar_Filter.Value*5+1);
            toolTip1.SetToolTip(trackBar_Filter, trackBar_Filter.Value.ToString());
        }

        private void TrackBar_Home_Scroll(object sender, EventArgs e)
        {
            listBox_Home.Font = new Font("New", trackBar_Home.Value*5+1);
            toolTip1.SetToolTip(trackBar_Home, trackBar_Home.Value.ToString());
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}




/*private void RadioButton_Repair_CheckedChanged_1(object sender, EventArgs e)
{
    numericUpDown1.Enabled = true;
    numericUpDown3.Enabled = false;
    textBox3.Enabled = false;
    textBox4.Enabled = false;
    textBox5.Enabled = false;
    textBox6.Enabled = false;
}

private void RadioButton_Intercom_CheckedChanged(object sender, EventArgs e)
{
    numericUpDown1.Enabled = false;
    numericUpDown3.Enabled = true;
    textBox3.Enabled = false;
    textBox4.Enabled = false;
    textBox5.Enabled = false;
    textBox6.Enabled = false;
}

private void CheckBox_Hot_Water_CheckedChanged(object sender, EventArgs e)
{
    numericUpDown1.Enabled = false;
    numericUpDown3.Enabled = false;
    textBox3.Enabled = true;
    textBox4.Enabled = true;
    textBox5.Enabled = false;
    textBox6.Enabled = false;
}

private void CheckBox_Cold_Water_CheckedChanged(object sender, EventArgs e)
{
    numericUpDown1.Enabled = false;
    numericUpDown3.Enabled = false;
    textBox3.Enabled = false;
    textBox4.Enabled = false;
    textBox5.Enabled = true;
    textBox6.Enabled = true;
}

private void Button_Baza_Click(object sender, EventArgs e)
{
    if (radioButton_Repair.Checked)
    {
        var repair = new Repair_Pay(comboBoxSurname.Text,
            (int)numericUpDown1.Value);
        list.Add(repair);
        listBox_Home.Items.Add(repair.Info());
    }
    else if (radioButton_Intercom.Checked)
    {
        var intercom = new Intercom_Pay(comboBoxSurname.Text,
            (int)numericUpDown3.Value);
        list.Add(intercom);
        listBox_Water.Items.Add(intercom.Info());
    }
    else if (checkBox_Hot_Water.Checked)
    {
        var hotwaetr = new Hotwater_Pay(comboBoxSurname.Text,
            int.Parse(textBox3.Text),
            int.Parse(textBox4.Text));
        list.Add(hotwaetr);
        listBox_Home.Items.Add(hotwaetr.Info());
    }
    else if (checkBox_Cold_Water.Checked)
    {
        try
        {
            var coldwaetr = new Coldwater_Pay(comboBoxSurname.Text,
            int.Parse(textBox5.Text),
            int.Parse(textBox6.Text));
            list.Add(coldwaetr);
            listBox_Home.Items.Add(coldwaetr.Info());
        }
        catch (FormatException)
        {
            MessageBox.Show("Неверные данные!");
        }

    }
    trackBar_Home.Maximum = list.Count;
    trackBar_Water.Maximum = list.Count;
}
*/





/*  ArrayList list;
        Dictionary<string, double> dict;
        Pay pay;
 * 
 * //Загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            list = new ArrayList();
            dict = new Dictionary<string, double>();
        }

        //Изменение состояния кнопки Капитальный ремонт
        private void RadioButton_Repair_CheckedChanged_1(object sender, EventArgs e)
        {
            numericUpDown1.Visible = !numericUpDown1.Visible;
        }

        //Изменение состояния кнопки Домофон
        private void RadioButton_Intercom_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown3.Visible = !numericUpDown3.Visible;
        }

        //Изменение состояния кнопки Горячая вода
        private void CheckBox_Hot_Water_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = !textBox3.Enabled;
            textBox4.Enabled = !textBox4.Enabled;
        }

        //Изменение состояния кнопки Холодная вода
        private void CheckBox_Cold_Water_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = !textBox5.Enabled;
            textBox6.Enabled = !textBox6.Enabled;
        }

        //Запоминание новой фамилии
        private void Button_Surname_Click(object sender, EventArgs e)
        {
            if (comboBox_Surname.Text.Length != 0)
                comboBox_Surname.Items.Add(comboBox_Surname.Text);
        }

        //Занесение платежа в базу
        private void Button_Baza_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_Surname.Text != "")
                {
                    if (radioButton_Repair.Checked)
                    {
                        pay = new Repair_Pay(comboBox_Surname.Text,
                            (int)numericUpDown1.Value);
                    }
                    else if (radioButton_Intercom.Checked)
                    {
                        pay = new Intercom_Pay(comboBox_Surname.Text,
                            (int)numericUpDown3.Value);
                    }
                    else if (checkBox_Repair.Checked)
                    {
                        pay = new Hotwater_Pay(comboBox_Surname.Text,
                            int.Parse(textBox3.Text),
                            int.Parse(textBox4.Text));
                    }
                    if (checkBox_Intercom.Checked)
                    {
                        pay = new Coldwater_Pay(comboBox_Surname.Text,
                        int.Parse(textBox5.Text),
                        int.Parse(textBox6.Text));
                    }
                }            
                else
                {
                    MessageBox.Show("Введите ФИО");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод");
            }
    }


        //Список платежей за жилищные услуги
        private void Button_Home_Click(object sender, EventArgs e)
        {
            listBox_Home.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                pay = (Pay)list[i];
                if ((pay.GetType().Name == "Repair_Pay") || (pay.GetType().Name == "Imtercom_Pay"))
                    listBox_Home.Items.Add(pay.Info());
            }
        }

        //Список платежей за коммунальные услуги
        private void Button_Water_Click(object sender, EventArgs e)
        {
            listBox_Filter.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                pay = (Pay)list[i];
                if ((pay.GetType().Name == "Hotwater_Pay") || (pay.GetType().Name == "Coldwater_Pay"))
                    listBox_Filter.Items.Add(pay.Info());
            }
        }

        //Сумма по всем платежам
        private void Button_Sum_Click(object sender, EventArgs e)
        {
            double s = 0;
            for (int i = 0; i < list.Count; i++)
            {
                pay = (Pay)list[i];
                s = s + pay.Sum();
            }
            textBox_Sum.Text = string.Format("{0:f2}", s);
        }

        //Выход
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Сумма по всем платежам
        private void TrackBar_Home_Scroll(object sender, EventArgs e)
        {
            listBox_Home.Font = new Font("Microsoft Sans Serif", trackBar_Home.Value);
        }

        private void TrackBar_Water_Scroll(object sender, EventArgs e)
        {
            listBox_Filter.Font = new Font("Microsoft Sans Serif", trackBar_Water.Value);
        }*/
