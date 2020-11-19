using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_6
{
    public class Triad
    {
        //Первое число
        public int num1
        {
            get; set;//автоматическое свойство
        }

        //Второе число
        public int num2
        {
            get; set;
        }

        //Третье число
        public int num3
        {
            get; set;
        }

        //Конструктор с начальными значениями
        public Triad()
        {
            num1 = 0;
            num2 = 0;
            num3 = 0;
        }

        //Заполнение случайными значениями
        public void Random()
        {
            Random rand = new Random();//Создание объекта rand
            num1 = rand.Next(0, 100);
            num2 = rand.Next(0, 100);
            num3 = rand.Next(0, 100);
        }

        //Вычисление суммы чисел триады
        //Возвращает сумму чисел 
        public int Summ()
        {
            return num1 + num2 + num3;
        }

        
    }
}
