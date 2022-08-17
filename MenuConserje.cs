using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestor_de_Condominio
{
    public partial class MenuConserje : Form
    {

        public MenuConserje(string NOMBRE)
        {
            InitializeComponent();

        }
        
          
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form R = new RegistrarResidente();
            R.Show();
            
        }

        private void MenuConserje_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarS_Click(object sender, EventArgs e)
        {
            Form S = new RegistrarServicio();
            S.Show();
            
        }

        private void RegistrarVisi_Click(object sender, EventArgs e)
        {
            Form V = new RegistrarVisita();
            V.Show();
        }

        private void RegistrarSalida_Click(object sender, EventArgs e)
        {
            Form C = new CerrarSesion();
            C.Show();
        }
    }
}
