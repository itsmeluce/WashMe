using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashMe2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 formKedua = new Form2();
            formKedua.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 formKelima = new Form5();
            formKelima.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
