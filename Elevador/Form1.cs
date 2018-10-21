using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevador
{
    public partial class Form1 : Form
    {
        Elevador elevador;

        public Form1()
        {
            InitializeComponent();
            elevador = new Elevador(9);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            elevador.irA(Convert.ToInt32(((Button)sender).Text));
            txtInfo.Text = elevador.ToString();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            elevador.abrirPuerta();
            txtInfo.Text = elevador.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            elevador.cerrarPuerta();
            txtInfo.Text = elevador.ToString();
        }
    }
}
