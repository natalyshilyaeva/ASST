using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication1
{
    //          MVC

    // ������� Observer ���������� ������ ��������� ���������� / �������� ����� ��������. 
    // �� ��������� ������� (�����������) ���������������� ���� ������������������ �
    // ������ ������� (�����������).
    //  ������ ���, ����� ����������� ����� ��������� ����� ������������ �� ���������,
    //  �� �������� � ����������� ����� Update() 

    public interface IObserver
    {
        void UpdateState();
    }
}
