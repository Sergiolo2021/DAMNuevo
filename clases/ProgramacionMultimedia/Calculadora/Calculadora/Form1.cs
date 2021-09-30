using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void suma_Click(object sender, EventArgs e)
        {
            //numeros.Text = Int64.Parse(numero1.Text) + Int64.Parse(resultado.Text) + ".";
            suma.BackColor = Color.FromArgb(13, 40, 53);
        }

        private void resta_Click(object sender, EventArgs e)
        {
            //numeros.Text = Int64.Parse(numero1.Text) - Int64.Parse(resultado.Text) + ".";
            resta.BackColor = Color.FromArgb(13, 40, 53);
        }

        private void division_Click(object sender, EventArgs e)
        {
            //numeros.Text = Int64.Parse(numero1.Text) / Int64.Parse(resultado.Text) + ".";
            division.BackColor = Color.FromArgb(13, 40, 53);
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            //numeros.Text = Int64.Parse(numero1.Text) * Int64.Parse(resultado.Text) + ".";
            multiplicacion.BackColor = Color.FromArgb(13, 40, 53);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            borrar.BackColor = Color.FromArgb(13, 40, 53);
        }

        private void numeros_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
