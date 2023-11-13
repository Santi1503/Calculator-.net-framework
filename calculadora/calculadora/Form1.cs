using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero (string numero)
        {
            if (txtResultado.Text == "0") {
                txtResultado.Text = "";

                txtResultado.Text += numero;
            }
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            var boton
            agregarNumero()
        }
    }
}
