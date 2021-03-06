using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{   // ���_1 (View_1)
    //  ��� � ��� ��� ���� ������ MVC, ������� ���������� ����������� ��� ��������� �������������
    //  ������. ��� �������� ��� ���������� � ��������� ������ �� ����� ������.
    //  ������������ ������ ����� ������� � ���������������� ����������� �������� �����
    //  ����� ������ ����������� �� ��������� ��������� �������.
    //  ���� ��� ��� ���������� �������������� � ����������� �� ��������� ��������� �������, 
    //  ��� �������������� � ������ ����� ������ �����������.
    //  ��� ������������ ���������� ���� ������������ ������� �����������  

    public partial class TrafficLightView : Form, IObserver
    {

        //              MVC

        private TrafficLightController controller;
        private TrafficLightModel model;
        public TrafficLightView(TrafficLightModel model)
        {
            InitializeComponent();
            this.model = model;
            //  ����������� (view) ������������ ���� ������������������ � ������
            this.model.Register(this);
            AttachController(MakeController());


        }
        //    ���������� ����
        //    ��� ����������� (view), ������� ����� ������������������ � ������������ �������,
        //    ������ ����������� ��������� Observer

        public void UpdateState()
        {
            pnGreen.BackColor = Color.Black;
            pnYellow.BackColor = Color.Black;
            pnRed.BackColor = Color.Black;
            if (model.SwitchedOn)

                //  ��������� ���������� �� � ��������� ������ �� ����� ������
                switch (model.State)
                {
                    case TrafficLightState.Red:
                        pnRed.BackColor = Color.Red;
                        break;
                    case TrafficLightState.Yellow:
                        pnYellow.BackColor = Color.Yellow;
                        break;
                    case TrafficLightState.Green:
                        pnGreen.BackColor = Color.Green;
                        break;
                }
        }

        //          ����������� ����������� � ����

        //  ���� ����� ��������� ������ ���������� � �����

        public void AttachController(TrafficLightController controller)
        {
            this.controller = controller;
        }

        protected TrafficLightController MakeController()
        {
            //          �������� ����������� ������ �� ��� � ������

            return new TrafficLightController(this, model);
        }



        //          ���������  � ������������� ������� ������ � ����� (�������� �� �����������)  

        private void btnSetInt_Click(object sender, EventArgs e)
        {
            double red = 0, yellow = 0, green = 0;
            try
            {
                red = double.Parse(tbRed.Text)*1000;
                yellow = double.Parse(tbYellow.Text)*1000;
                green = double.Parse(tbGreen.Text)*1000;
            }
            catch { MessageBox.Show("������� ���������� ���������!"); }
            try
            {
                controller.SetIntervals(red, yellow, green);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            try
            {
                controller.SwithOn();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            controller.SwitchOff();
        }

    }
}

