using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooFormExer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Area_Aresta(object sender, EventArgs e)
        {
            int ares, resul;
            ares = int.Parse(aresta.Text);
            resul = ares*ares;
            Resultado.Text = resul.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
