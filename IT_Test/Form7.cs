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
    public partial class Form7 : Form
    {
        Form6 form6 = new Form6();
        public int true_answear;
        public int false_answear;

        public static int True;
        public static int False;

        public Form7(int t, int f)
        {
            InitializeComponent();
            radioButton1.Checked = true;

            true_answear += t;
            false_answear += f;
        }

        public Form7()
        {
            InitializeComponent();
            radioButton1.Checked = true;

            true_answear = Form6.True;
            false_answear = Form6.False;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            form6.ShowDialog();

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();

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

            Form8 form8 = new Form8(true_answear, false_answear);
            form8.ShowDialog();

            Close();
        }
    }
}
