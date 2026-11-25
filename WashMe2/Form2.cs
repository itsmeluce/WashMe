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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegAdmin_Click(object sender, EventArgs e)
        {
            Form3 formKetiga = new Form3();
            formKetiga.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 formKeempat = new Form4();
            formKeempat.Show();
            this.Hide();
        }
    }
}
