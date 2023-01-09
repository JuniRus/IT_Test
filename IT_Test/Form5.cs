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
        Form4 form4 = new Form4();
        public int true_answear = 0;
        public int false_answear = 0;

        public static int True;
        public static int False;

        public Form5(int t, int f)
        {
            InitializeComponent();
            radioButton1.Checked = true;

            true_answear += t;
            false_answear += f;
        }

        public Form5()
        {
            InitializeComponent();
            radioButton1.Checked = true;

            true_answear = Form4.True;
            false_answear = Form4.False;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            form4.ShowDialog();

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();

            if (radioButton1.Checked)
                false_answear++;
            else if (radioButton2.Checked)
                false_answear++;
            else if (radioButton3.Checked)
                false_answear++;
            else if (radioButton4.Checked)
                true_answear++;

            True = true_answear;
            False = false_answear;

            Form6 form6 = new Form6(true_answear, false_answear);
            form6.ShowDialog();

            Close();
        }
    }
}
