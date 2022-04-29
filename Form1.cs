using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula33_Exercicios
{
    public partial class Form1 : Form
    {
        List<string> listA = new List<string>();
        List<string> listB = new List<string>();
        List<string> listC = new List<string>();

        public Form1()
        {
            InitializeComponent();
            rbListA.Checked = true;
            txtItem.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (rbListA.Checked)
            {
                listA.Add(txtItem.Text);
            } else if (rbListB.Checked)
            {
                listB.Add(txtItem.Text);
            } else
            {
                lblErro.Text = "Não é possível adicionar nas duas listas!";
            }

            txtItem.Clear();
        }

        private void lbListas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rbLists_CheckedChanged(object sender, EventArgs e)
        {
            lbListas.Items.Clear();
            foreach (string item in listA)
            {
                lbListas.Items.Add(item);
            }
            foreach (string item in listB)
            {
                lbListas.Items.Add(item);
            }
        }

        private void rbListB_CheckedChanged(object sender, EventArgs e)
        {
            lbListas.Items.Clear();
            foreach (string item in listB)
            {
                lbListas.Items.Add(item);
            }
        }

        private void rbListA_CheckedChanged(object sender, EventArgs e)
        {
            lbListas.Items.Clear();            
            foreach (string item in listA)
            {
                lbListas.Items.Add(item);
            }
        }
    }
}
