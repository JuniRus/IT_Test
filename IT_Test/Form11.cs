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
    public partial class Form11 : Form
    {
        Form10 form10 = new Form10();
        public int true_answear = 0;
        public int false_answear = 0;

        public static int True;
        public static int False;

        public Form11(int t, int f)
        {
            InitializeComponent();

            true_answear += t;
            false_answear += f;

            if (true_answear > 7)
                label2.Text = "Вы отлично разбираетесь в IT!";
            else if (true_answear < 8 && true_answear > 5)
                label2.Text = "Вы хорошо разбираетесь в IT!";
            else if (true_answear < 6 && true_answear > 3)
                label2.Text = "Вы неплохо понимаете IT!";
            else if (true_answear < 4)
                label2.Text = "Вы плохо разбираетесь в IT!";

            label3.Text = "Правильных ответов: " + true_answear;
            label4.Text = "Неверных ответов: " + false_answear;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            form10.ShowDialog();

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
