using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            Eratostenes Era = new Eratostenes(1000);
            //MessageBox.Show("Primos : "+ Era.Primos());
            txtResultado.Text = Era.Primos();
        }
    }
}
