using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication1
{
   // ���������� � ��� ��� ���� ������ MVC, ������� �������������� ������, �������� �������������
   // � ����� �� ������, �������� �������������, ���������� �������� ������� ������
   // ��� ���� ��� ��������� ��������� ��� ���������� ������-���� ��������.

    //  ����� �������� ������� ���� �� �������� ������������ (��������, �������������� ���),
    //  ��������� �������� ������� ������������ (������� ���������)

    public class TrafficLightController
    {
        private TrafficLightModel model;
        private TrafficLightView view;
        public TrafficLightController(TrafficLightView view, TrafficLightModel model)
        {
            this.model = model;
            this.view = view;
        }
       public void SetIntervals(double red, double yellow, double green)
        {
            if (model.SwitchedOn) throw new Exception("���������� �������� ��������� � ���������� ���������!");
            Intervals i = new Intervals(red, yellow, green);
            model.SetIntervals(i);
        }       
        public void SwithOn()
        {
            if (model.IntervalsEmpty) throw new Exception("�� ������ ��������� ������������!");
            model.SwitchedOn = true;
        }
        public void SwitchOff()
        {
            model.SwitchedOn = false;
        }
    }
}
