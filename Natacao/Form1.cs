using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Natacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int idade;
            idade = Convert.ToInt32(txtIdade.Text);
            if (idade > 120)
            {
                MessageBox.Show("Idade Inadequada");
            }
            else if (idade > 17)
            {
                MessageBox.Show("Categoria Adulta");
            }
            else if (idade > 13)
            {
                MessageBox.Show("Categoria Juvenil B");
            }
            else if (idade > 10)
            {
                MessageBox.Show("Categoria Juvenil A");
            }
            else if (idade > 7)
            {
                MessageBox.Show("Categoria Infantil B");
            }
            else if (idade > 4)
            {
                MessageBox.Show("Categoria Infantil A");
            }
            else
            {
                MessageBox.Show("Idade Inadequada");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdade.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
