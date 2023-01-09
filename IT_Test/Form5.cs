using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Test
{
    public partial class Form5 : Form
    {
        // Создание объекта предыдущего вопроса.
        Form4 form4 = new Form4();
        // Переменные, хранящие в себе ответы.
        public int true_answear = 0;
        public int false_answear = 0;

        // Статические переменные, которые будут содержать в себе
        // результаты ответа на текущий вопрос.
        public static int True;
        public static int False;

        // Конструктор для предыдущего вопроса кнопки "Дальше".
        public Form5(int t, int f)
        {
            InitializeComponent();
            radioButton1.Checked = true;

            // Сохранение ответов из предыдущей формы.
            true_answear += t;
            false_answear += f;
        }

        // Конструктор для кнопки "Назад" из следущей формы.
        public Form5()
        {
            InitializeComponent();
            radioButton1.Checked = true;

            // Взять результаты ответов предыдущей формы.
            true_answear = Form4.True;
            false_answear = Form4.False;
        }

        // Нажатие на кнопку "Назад".
        private void button1_Click(object sender, EventArgs e)
        {
            // Спрятать текущий вопрос.
            Hide();

            // Показать предыдущий вопрос.
            form4.ShowDialog();

            // Закрыть окно текущего вопроса.
            Close();
        }

        // Нажатие на кнопку "Дальше".
        private void button2_Click(object sender, EventArgs e)
        {
            // Скрыть текущую форму.
            Hide();

            // Изменение значений при выборе ответа.
            if (radioButton1.Checked)
                false_answear++;
            else if (radioButton2.Checked)
                false_answear++;
            else if (radioButton3.Checked)
                false_answear++;
            else if (radioButton4.Checked)
                true_answear++;

            // Статические переменные, содержащие результаты
            // ответов данного вопроса
            True = true_answear;
            False = false_answear;

            // Передать ответы в следущий вопрос
            Form6 form6 = new Form6(true_answear, false_answear);
            // Показать следущий вопрос.
            form6.ShowDialog();

            // Закрыть текущий вопрос.
            Close();
        }
    }
}
