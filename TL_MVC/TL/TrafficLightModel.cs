using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Timers;

namespace WindowsApplication1
{
    public enum TrafficLightState
    {
        Red = 0,
        Yellow = 1,
        Green = 2
    }

    public struct Intervals
    {
        double red;
        double yellow;
        double green;
        public Intervals(double red, double yellow, double green)
        {
            this.red = red;
            this.yellow = yellow;
            this.green = green;
        }
        public double Red { get { return red; } }
        public double Yellow { get { return yellow; } }
        public double Green { get { return green; } }
        public bool AreEmpty { get { return red == 0 || yellow == 0 || green == 0; } }
    }

    //  ������ � ��� ����� ���� ������, ������� ������������ �������
    //  ������ � ��� ���� ������ MVC, ������� ��������� ���������� ���� � ���������� �������.
    //  ������ ��������: 1) �� ������� � �� ���������, ����������� �� ���� � �����������, � �����
    //                   2) �� ������� ��������� ���������, ����������� �� �����������.
   

    public class TrafficLightModel
    {
        private TrafficLightState state;
        private bool switchedOn;
        private Timer timer;
        private Intervals intervals;

        public TrafficLightModel()
        {
            state = TrafficLightState.Red;
            switchedOn = false;
            timer = new Timer();
            timer.AutoReset = true;     // �������������� �����
            timer.Enabled = false;      // ���������
            timer.Elapsed += timer_Elapsed;    
        }

        public bool SwitchedOn      //�������
        {
            get { return switchedOn || state != TrafficLightState.Red; }
            set
            {
                switchedOn = value;
                if (value)
                {
                    timer.Interval = intervals.Red;
                    timer.Enabled = true; 
                    UpdateObservers();
                }
            }
        }

        public TrafficLightState State { get { return state; } }

        public bool IntervalsEmpty { get { return intervals.AreEmpty; } }



        public void SetIntervals(Intervals intervals)       // ��������� ����������
        {
            this.intervals = intervals;
        }


        void timer_Elapsed(object sender, ElapsedEventArgs e)       // ���������� �������
        {
            state = (TrafficLightState)(((int)state + 1) % 3);
            switch (state)
            {
                case TrafficLightState.Red: timer.Interval = intervals.Red;
                    break;
                case TrafficLightState.Yellow: timer.Interval = intervals.Yellow;
                    break;
                case TrafficLightState.Green: timer.Interval = intervals.Green;
                    break;
            }
            if (state == TrafficLightState.Red && !switchedOn) // ���� �������� ������� ���������� �������
            {
                timer.Enabled = false;
            }
            //  ��� ��������� ��������� ������, ��� ���������� ������ ������������������
            //  �������� (�� ����� ��� �������� �����������, �����������, ����������� ���������� (listener),
            //  �������������, �������������, � ����� ������� ���������� (observer)), � ��������������
            //  ������ ������ �� ��������� ���������.

            UpdateObservers();
        }

       //        MVC
       //      ������ ������������ 
        private ArrayList listeners = new ArrayList();

       // ����������� (������) ������ ����� ������, � ������� ������� ����������� (view) ����� ��-
       //  �������������� ���� ������������������ � ������ � �������� ��

        public void Register(IObserver o)
        {
            listeners.Add(o);
            o.UpdateState();
        }

        public void Deregister(IObserver o)
        {
            listeners.Remove(o);
        }

        //  ����� ��� ���������� ���� �����

        // ��� �������� ������ ����������� ������, ���
        //  �������, ����������� ������ Observer (�����������, ���� ����������).
        public void UpdateObservers()
        {
            foreach (IObserver ob in listeners)
            {
                ob.UpdateState();
            }
        }
    }
}
