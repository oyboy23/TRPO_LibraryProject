using System;
using System.Text.RegularExpressions;

#region ПРОЧТИ
///  ЭТО ВЕЛИКОЛЕПНАЯ БИБЛИОТЕКА КЛАССОВ
///  ВСЕ ЧТО ОТ ВАС НАДО - ЭТО СОЗДАТЬ СВОЙ СОБСТВЕННЫЙ !!КЛАСС!!
///  И НАД НИМ ПОДПИСАТЬ В ЧТО ОН, КТО ОН, КЕМ ОН.
///  ПРИ КОММИТЕ ВЫ УКАЗЫВАЕТЕ ВАРИАНТ
///  ЕСЛИ БИБЛИОТЕК ВДРУГ СТАЛО БОЛЬШЕ ЧЕМ ЭТО
///  ТО ВЫ СНОВА БУБЫЛДА ДУРАЦКАЯ И ВСЕ СЛОМАЛИ
#endregion

namespace MAIN_LIBRARY
{
    #region ПРИМЕР КЛАССА
    /// <summary>
    /// НАЗВАНИЕ КЛАССА
    /// ВАРИАНТ ЗАДАНИЯ
    /// ФИО ИСПОЛНИТЕЛЯ
    /// </summary>
    public class NAME                   //УДАЛИТЕ ЭТО ИЛИ ЗАКОМЕНТИРУЙТЕ ПОСЛЕ СОЗДАНИЯ НЕСКОЛЬКИХ КЛАССОВ, ПАЖЕ ПАЖЕ 
    {
        //тут ваши поля и их автоматические условия
        private FIELD_TYPE FIELD_NAME1;

        public FIELD_TYPE FIELD_NAME2;
        {
            set { FIELD_NAME1 = value; }
            get { return FIELD_NAME1; }
        }

        //конструктор класса
        public NAME(FIELD_TYPE FIELD_INPUT_NAME)
        {
            FIELD_NAME2 = FIELD_INPUT_NAME;
        }
    }
    #endregion

    /// <summary>
    /// Класс должность
    /// Вариант 10
    /// Малегин Дмитрий
    /// </summary>
    public class Doljnost
    {
        private string _name;
        private double _salary;
        private Podrozdelenie _podrozdelenie; //Балванка под пока не существующий класс ПОДРАЗДЕЛЕНИЕ

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public double Salary
        {
            set
            {
                if (value >= 0) { _salary = value; }
                else { throw new ArgumentOutOfRangeException(); }

            }
            get { return _salary; }
        }

        public Doljnost(string name, double salary, Podrozdelenie podrozdelenie)
        {
            Name = name;
            Salary = salary;
            _podrozdelenie = podrozdelenie;
        }
    }

    /// <summary>
    /// Класс Студент
    /// Вариант 5
    /// Клюев Никита
    /// </summary>
    public class Student
    {
        private string Group1 _group1; // - балванка так как нет работы на чью надо ссылаться,а именно на вариант 4 Группа.
        private string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string otchestvo;
        public string OTchestvo
        {
            get { return otchestvo; }
            set { otchestvo = value; }
        }


        private DateTime dateofbirth;
        public DateTime Dateofbirth
        {
            get { return dateofbirth; }
            set { dateofbirth = value; }

        }
        public Student(string surname, string name, string otchestvo, DateTime dateofbith, Group1 group1)
        {
            Surname = surname;
            Name = name;
            OTchestvo = otchestvo;
            Dateofbirth = dateofbith;
            _group1 = group1;
        }
    }

    /// <summary>
    /// Класс Аудитория
    /// Вариант 2
    /// Дайлиденок Никита
    /// </summary>
    public class Auditoria
    {
        private string _Name;
        //private Sotrydnik _sotrydnic;
        private string _Seat = "23";
        private string _Windows = "2";
        //private Oborydovanie _oborydovanie;

        public string Name { get; set; }
        public string Seat { get; set; }
        public string Windows { get; set; }
        public Auditoria(string name, /*Sotrydnic sotrydnic,*/ string seat, /*Oborydovanie oborydovanie,*/ string windows)
        {
            _Name = name;
            //_sotrydnic = sotrydnic;
            _Seat = seat;
            _Windows = windows;
            //_oborydovanie = oborydovanie;
        }
    }
}
