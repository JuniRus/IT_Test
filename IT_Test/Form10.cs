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
    public partial class Form10 : Form
    {
        Form9 form9 = new Form9();
        public int true_answear = 0;
        public int false_answear = 0;

        public static int True;
        public static int False;

        public Form10(int t, int f)
        {
            InitializeComponent();
            radioButton1.Checked = true;

            true_answear += t;
            false_answear += f;
        }

        public Form10()
        {
            InitializeComponent();
            radioButton1.Checked = true;

            true_answear = Form9.True;
            false_answear = Form9.False;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            form9.ShowDialog();

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
                true_answear++;
            else if (radioButton4.Checked)
                false_answear++;

            True = true_answear;
            False = false_answear;

            Form11 form11 = new Form11(true_answear, false_answear);
            form11.ShowDialog();

            Close();
        }
    }
}
