using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSenac
{
    public partial class Form1 : Form
    {
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        void Calcular()
        {

        }

        void Limpar()
        {
            // apagar o texto dos 3 campos
            txtNome.Text = "";   
        }
    }
}
