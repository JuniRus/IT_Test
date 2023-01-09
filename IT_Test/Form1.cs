using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Test
{
    public partial class Form1 : Form
    {
        // Переменные, хранящие в себе ответы.
        public int true_answear = 0;
        public int false_answear = 0;

        // Статические переменные, которые будут содержать в себе
        // результаты ответа на текущий вопрос.
        public static int True;
        public static int False;

        // Конструктор для создания формы
        public Form1()
        {
            InitializeComponent();
            // Явно выбрать изначально первый ответ.
            radioButton1.Checked = true;
        }

        // Нажатие на кнопку "Дальше".
        private void button1_Click(object sender, EventArgs e)
        {
            // Скрыть текущую форму.
            Hide();

            // Изменение значений при выборе ответа.
            if(radioButton1.Checked)
                false_answear++;
            else if(radioButton2.Checked)
                false_answear++;
            else if(radioButton3.Checked)
                false_answear++;
            else if(radioButton4.Checked)
                true_answear++;

            // Статические переменные, служащие для передачи информации
            // об ответах текущего вопроса.
            True = true_answear;
            False = false_answear;

            // Передать ответы в следущий вопрос.
            Form2 form2 = new Form2(true_answear, false_answear);
            // Показать следущий вопрос.
            form2.ShowDialog();

            // Закрыть текущий вопрос.
            Close();
        }
    }
}
