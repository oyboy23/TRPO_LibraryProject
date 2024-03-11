using System;

///  ЭТО ВЕЛИКОЛЕПНАЯ БИБЛИОТЕКА КЛАССОВ
///  ВСЕ ЧТО ОТ ВАС НАДО - ЭТО СОЗДАТЬ СВОЙ СОБСТВЕННЫЙ !!КЛАСС!!
///  И НАД НИМ ПОДПИСАТЬ В ЧТО ОН, КТО ОН, КЕМ ОН.
///  ПРИ КОММИТЕ ВЫ УКАЗЫВАЕТЕ ВАРИАНТ
///  ЕСЛИ БИБЛИОТЕК ВДРУГ СТАЛО БОЛЬШЕ ЧЕМ ЭТО
///  ТО ВЫ СНОВА БУБЫЛДА ДУРАЦКАЯ И ВСЕ СЛОМАЛИ

namespace MAIN_LIBRARY
{
    public class NAME //тут название своего класса и все что внутри его
    {

    }

    /// <summary>
    /// КЛАСС ДОЛЖНОСТЬ
    /// ВАРИАНТ 10
    /// МАЛЕГИН ДМИТРИЙ
    /// </summary>
    public class Doljnost
    {
        private string _name;
        private double _salary;
        private Podrozdelenie _podrozdelenie;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Doljnost(string name, double salary, Podrozdelenie podrozdelenie)
        {
            _name = name;
            _salary = salary;
            _podrozdelenie = podrozdelenie;
        }
    }

    /// <summary>
    /// ЧТО ЭТО
    /// КАКОЙ ВАРИАНТ
    /// КТО СДЕЛАЛ
    /// </summary>
    public class Podrozdelenie
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Podrozdelenie(string name)
        {
            _name = name;
        }
    }
    
}
