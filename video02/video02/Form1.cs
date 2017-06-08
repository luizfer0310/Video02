using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void certo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Certo faça a proxima questão!");
            label3.Visible = true;
            certo2.Visible = true;
            errado2.Visible = true;
        }

        private void errado1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você errou assista o video novamente e tente outra vez!!");
            this.Close();
        }

        private void errado2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você errou assista o video novamente e tente outra vez!!");
            this.Close();
        }

        private void certo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Certo faça a proxima questão!");
            label4.Visible = true;
            certo3.Visible = true;
            errado3.Visible = true;
        }

        private void certo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parabêns você acertou todas as questôes!");
            this.Close();
        }

        private void errado3_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Você errou assista o video novamente e tente outra vez!!");
            this.Close();
        }
    }
}
