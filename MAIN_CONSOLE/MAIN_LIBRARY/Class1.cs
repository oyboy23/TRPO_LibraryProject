using System;

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
        public NAME( FIELD_TYPE FIELD_INPUT_NAME )
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
}
