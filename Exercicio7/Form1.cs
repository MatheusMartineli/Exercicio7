using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lsbResultado.Items.Clear();

            int razao = int.Parse(txtRazao.Text),
            valor_pa = int.Parse(txtRazao.Text);

            int i = 0;
            while (i < 10)
            {
                lsbResultado.Items.Add(valor_pa);
                valor_pa += razao;
                i++;
            }

        }
    }
 }
    

