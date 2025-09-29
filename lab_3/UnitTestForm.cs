using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    public partial class UnitTestForm : Form
    {
        public UnitTestForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var t1 = new task1(
                    Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text),
                    Convert.ToInt32(textBox3.Text)
                    );

                label5.Text = "Result: " + t1.GetNumOfMultiples().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var t2 = new task2(
                    Convert.ToInt32(textBox4.Text),
                    Convert.ToInt32(textBox5.Text)
                    );

                label10.Text = "Result: " + t2.CalcSum().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
