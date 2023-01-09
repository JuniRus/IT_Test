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
    public partial class Form6 : Form
    {
        Form5 form5 = new Form5();
        public int true_answear = 0;
        public int false_answear = 0;

        public static int True;
        public static int False;

        public Form6(int t, int f)
        {
            InitializeComponent();
            radioButton1.Checked = true;

            true_answear += t;
            false_answear += f;
        }

        public Form6()
        {
            InitializeComponent();
            radioButton1.Checked = true;

            true_answear = Form5.True;
            false_answear = Form5.False;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            form5.ShowDialog();

            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();

            if (radioButton1.Checked)
                false_answear++;
            else if (radioButton2.Checked)
                true_answear++;
            else if (radioButton3.Checked)
                false_answear++;
            else if (radioButton4.Checked)
                false_answear++;

            True = true_answear;
            False = false_answear;

            Form7 form7 = new Form7(true_answear, false_answear);
            form7.ShowDialog();

            Close();
        }
    }
}
