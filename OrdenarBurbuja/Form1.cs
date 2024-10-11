using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenarBurbuja
{
    public partial class FrmPrincipal : Form
    {
        Random random = new Random();
        int[] numeros;

        public FrmPrincipal()
        {
            InitializeComponent();
            numeros = new int[1000];
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrdernar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 1000; i++)
            {
                lstNumeros.Items.Add(random.Next(1000));
            }

            toolStrip1.Text = lstNumeros.Items.Count.ToString();
        }
    }
}
