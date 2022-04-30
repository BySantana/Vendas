using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        private void btnLancar_Click(object sender, EventArgs e)
        {
           
            lstProduto.Items.Add(txtProduto.Text);
            lstPreco.Items.Add(txtPreco.Text);
            double total = double.Parse(label3.Text);
            total += double.Parse(txtPreco.Text);
            label3.Text = total.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            
            double total = double.Parse(label3.Text);
            for (int i = 0; i < lstPreco.Items.Count; i++)
            {
                if (lstProduto.Items[i].ToString() == lstProduto.Text)
                {
                    total -= double.Parse(lstPreco.Items[i].ToString());
                    lstPreco.Items.RemoveAt(i);
                    lstProduto.Items.RemoveAt(i);
                    label3.Text = total.ToString();
                }
                
            }
            
        }
    }
}
