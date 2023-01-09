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
    public partial class Form8 : Form
    {
        Form7 form7 = new Form7();
        public int true_answear;
        public int false_answear;

        public static int True;
        public static int False;

        public Form8(int t, int f)
        {
            InitializeComponent();
            radioButton1.Checked = true;

            true_answear += t;
            false_answear += f;
        }

        public Form8()
        {
            InitializeComponent();
            radioButton1.Checked = true;

            true_answear = Form7.True;
            false_answear = Form7.False;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            form7.ShowDialog();

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

            Form9 form9 = new Form9(true_answear, false_answear);
            form9.ShowDialog();

            Close();
        }
    }
}
