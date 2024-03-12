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
        //private Sotrydnik _sotrydnic; Балванка, нет класса сотрудник вариант 9
        private string _Seat = "23";
        private string _Windows = "2";
        //private Oborydovanie _oborydovanie; В группе не делается такой вариант

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Seat
        {
            get { return _Seat; }
            set { _Seat = value; }
        }
        public string Windows
        {
            get { return _Windows; }
            set { _Windows = value; }
        }
        public Auditoria(string name, /*Sotrydnic sotrydnic,*/ string seat, /*Oborydovanie oborydovanie,*/ string windows)
        {
            _Name = name;
            //_sotrydnic = sotrydnic;
            _Seat = seat;
            _Windows = windows;
            //_oborydovanie = oborydovanie;
        }
    }

    /// <summary>
    /// Класс Подразделение
    /// Вариант 11
    /// Носков Иван
    /// </summary>
    public class Podrozdelenie
    {
        private string _nazvanie;
        private string _rukovoditel;
        private Organizaciya _organizaciya;

        public string Nazvanie
        {
            get { return _nazvanie; }
            set { _nazvanie = value; }
        }

        public string Rukovoditel
        {
            get { return _rukovoditel; }
            set { _rukovoditel = value; }
        }

        public Organizaciya Organizaciya
        {
            get { return _organizaciya; }
            set { _organizaciya = value; }
        }

        public Podrozdelenie(string nazvanie, string rukovoditel, Organizaciya organizaciya)
        {
            Nazvanie = nazvanie;
            Rukovoditel = rukovoditel;
            Organizaciya = organizaciya;
        }
    }
    /// <summary>
    /// Класс Группа
    /// Вариант 4
    /// Киселёв Александр
    /// </summary>
    public class Group1
    {
        private string _nazvanie;
        private string _sokrachenie;
        private string _chislennost;
        private int _godpostuplenija;
        private string Sotrudnik _sotrudnic; //Нет варианта 9 (Сотрудник)
        private string Specialnost _specialnost; //Нет варианта 6 (Специальность)
        public string Nazvanie
        {
            get { return _nazvanie; }
            set { _nazvanie = value; }
        }
        public string Sokrachenie
        {
            get { return _sokrachenie; }
            set { _sokrachenie = value; }
        }
        public string Chislennost
        {
            get { return _chislennost; }
            set { _chislennost = value; }
        }
        public int Godpostuplenija
        {
            set
            {
                if (value >= 0) { _godpostuplenija = value; }
                else { throw new ArgumentOutOfRangeException(); }

            }
            get { return _godpostuplenija; }
        }
        public string Sotrudnik 
        {
            get { return _sotrudik; }
            set { _sotrudnic = value; }
        }
        public string Specialnost
        {
            get { return _specialnost; }
            set { _specialnost = value; }
        }
        public Group1(string nazvanie, string sokrachenie, string chislennost, int godpostuplenija, Sotrudnik sotrudnic, Specialnost specialnost)
        {
            Nazvanie = nazvanie;
            Sokrachenie = sokrachenie;
            Chislennost = chislennost;
            Godpostuplenija = godpostuplenija;
            _sotrudnic = sotrudnic;
            _specialnost = specialnost;

        }
    }
    /// <summary>
    /// Класс дисциплина
    /// Вариант 3
    /// Доронин Александр
    /// </summary>
     public class discipline
 {
     private string name;
     private string reduction;

     public discipline(string name, string reduction)
     {
         this.name = name;
         this.reduction = reduction;
     }
 }
    /// <summary>
    /// Класс корпус
    /// Вариант 13
    /// Смирнов Евгений
    /// </summary>
    public class Corpus
    {
        private string Name { get; set; }
        private string Adress { get; set; }
        private string Comm { get; set; }
        private string Org { get; set; }

        public Corpus(string name, string adress)
        {
            Name = name;
            Adress = adress;
            Comm = "-"; /// нет класса
            Org = "-"; /// нет класса
        }
    }
    public class Smena
    {
        public string Name { get; }
        public Smena(string name)
        {
            Name = name;

        }
    }
}
    

