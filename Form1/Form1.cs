using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Somar : Form
    {
        Somando s = new Somando();
        public Somar()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            s.numero1 = int.Parse(txtValor1.Text);
            s.numero2 = int.Parse(txtValor2.Text);
            txtResultado.Text = s.Calculo().ToString();
        }
    }
}
