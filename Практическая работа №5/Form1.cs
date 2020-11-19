using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_6;

namespace Практическая_работа__5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Кнопка Справка
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила Алешина Дарья гр.ИСП-31" +
                "Вариант 6" +
                "Создать класс Triad (тройка положительных чисел). Создать необходимые методы и свойства" +
                "Определить метод вычисления суммы чисел" +
                "Создать перегруженные методы SetParams, для установки параметров объекта");
        }

        //Кнопка Выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Создание объекта triada
        private Triad triada = new Triad();

        //Кнопка Заполнить
        private void button1_Click(object sender, EventArgs e)
        {
            triada.Random();
            textBox1.Text = triada.num1.ToString();
            textBox2.Text = triada.num2.ToString();
            textBox3.Text = triada.num3.ToString();
        }

        //Кнопка Расчитать
        private void button2_Click(object sender, EventArgs e)
        {
             triada.Summ();
            textBox4.Text = triada.Summ().ToString(); 
        }

        //Начальные значения
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = triada.num1.ToString();
            textBox2.Text = triada.num2.ToString();
            textBox3.Text = triada.num3.ToString();
        }

        //Кнопка Очистить
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        //Кнопка Задать для первого числа
        private void button3_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox1.Text, out int n1))
            {
                triada.num1 = n1;
                textBox1.Text = triada.num1.ToString();
            }
            else
            {
                MessageBox.Show("Число задано неправильно");
            }
        }

        //Кнопка Задать для второго числа
        private void button4_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox2.Text, out int n2))
            {
                triada.num2 = n2;
                textBox2.Text = triada.num2.ToString();
            }
            else
            {
                MessageBox.Show("Число задано неправильно");
            }
        }

        //Кнопка Задать для третьего числа
        private void button5_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox3.Text, out int n3))
            {
                triada.num3 = n3;
                textBox3.Text = triada.num3.ToString();
            }
            else
            {
                MessageBox.Show("Число задано неправильно");
            }
        }
    }
}
