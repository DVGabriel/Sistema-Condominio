using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_Gestor_de_Condominio
{
    public partial class CerrarSesion : Form
    {
        private Timer ti;
        public CerrarSesion()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
        }
        private void eventoTimer(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
           lblHora.Text = hoy.ToString("hh:mm:ss tt");

            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void CerrarSesion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
            SqlCommand comando = new SqlCommand("select USUARIO_CONTROL,FECHA_ENTRADA_US,HORA_ENTRADA_US,HORA_SALIDA_US , FECHA_SALIDA from CONTROL_CONDOMINIO  ", con);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
            int flag = 0;
            string cadena = "update CONTROL_CONDOMINIO SET HORA_SALIDA_US='" + lblHora.Text+ "',FECHA_SALIDA='" + lblFecha.Text +  "' WHERE USUARIO_CONTROL='" + textBox1.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            flag = comando.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show("Actualizado");

            }
            else
            {
                MessageBox.Show("Actualizado");

            }
            con.Close();
        }
    }
}
