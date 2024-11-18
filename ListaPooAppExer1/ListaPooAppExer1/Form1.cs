using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooAppExer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Area(object sender, EventArgs e)
        {
            int al, bs, resul;
            al = int.Parse(N1.Text);
            bs = int.Parse(N2.Text);
            resul= al*bs;
            Resul.Text = resul.ToString();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
