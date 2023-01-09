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
    public partial class Form4 : Form
    {
        // Создание объекта предыдущего вопроса.
        Form3 form3 = new Form3();
        // Переменные, хранящие в себе ответы.
        public int true_answear = 0;
        public int false_answear = 0;

        public static int True;
        public static int False;

        // Конструктор для предыдущего вопроса кнопки "Дальше".
        public Form4(int t, int f)
        {
            InitializeComponent();
            radioButton1.Checked = true;

            // Сохранение ответов из предыдущей формы.
            true_answear += t;
            false_answear += f;
        }

        public Form4()
        {
            InitializeComponent();
            radioButton1.Checked = true;

            true_answear = Form3.True;
            false_answear = Form3.False;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Спрятать текущий вопрос.
            Hide();

            // Показать предыдущий вопрос.
            form3.ShowDialog();

            // Закрыть окно текущего вопроса.
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Скрыть текущую форму.
            Hide();

            // Изменение значений при выборе ответа.
            if (radioButton1.Checked)
                true_answear++;
            else if (radioButton2.Checked)
                false_answear++;
            else if (radioButton3.Checked)
                false_answear++;
            else if (radioButton4.Checked)
                false_answear++;

            True = true_answear;
            False = false_answear;

            // Передать ответы в следущий вопрос
            Form5 form5 = new Form5(true_answear, false_answear);
            // Показать следущий вопрос.
            form5.ShowDialog();

            // Закрыть текущий вопрос.
            Close();
        }
    }
}
