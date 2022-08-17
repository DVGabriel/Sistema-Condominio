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
    public partial class RegistrarVisita : Form
    {
        public RegistrarVisita()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
            string CADENA = "INSERT INTO VISITANTES (ID_V,NOMBRE,RUT,IDENTIFICACION,HORA_ENTRADA,FECHA_ENTRADA)  VALUES(@ID_V,@NOMBRE,@RUT,@IDENTIFICACION,@HORA_ENTRADA,@FECHA_ENTRADA)";
            SqlCommand comando = new SqlCommand(CADENA, con);
            comando.Parameters.AddWithValue("@ID_V", txtID.Text);
            comando.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
            comando.Parameters.AddWithValue("@RUT", txtRut.Text);
            comando.Parameters.AddWithValue("@IDENTIFICACION", comboCarnet.Text);
            comando.Parameters.AddWithValue("@HORA_ENTRADA", txtHoraEntrada.Text);
            comando.Parameters.AddWithValue("@FECHA_ENTRADA", txtHoraEntrada.Text);
      
            comando.ExecuteNonQuery();

            MessageBox.Show("Datos registrados");
            con.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
            int flag = 0;
            string cadena = "update VISITANTES SET NOMBRE='" + txtNombre.Text + "',RUT='" + txtRut.Text + "',IDENTIFICACION='" + comboCarnet.Text + "',HORA_ENTRADA='" + txtHoraEntrada.Text + "',FECHA_ENTRADA='" + txtFechaEntrada.Text + "' WHERE ID_V='" + txtID.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            flag = comando.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show("Actualizado");

            }
            else
            {
                MessageBox.Show("no se encontro registro");

            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
            SqlCommand comando = new SqlCommand("select ID_V,NOMBRE,RUT,IDENTIFICACION,HORA_ENTRADA,HORA_SALIDA,FECHA_ENTRADA , FECHA_SALIDA  from VISITANTES  ", con);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
            int flag = 0;
            string cadena = "update VISITANTES SET HORA_SALIDA='" + txtHrsSalida.Text + "',FECHA_SALIDA='" + txtFechaSalida.Text + "' WHERE ID_V='" + txtidRetirada.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            flag = comando.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show("Actualizado");

            }
            else
            {
                MessageBox.Show("no se encontro registro");

            }
            con.Close();
        }

        private void RegistrarVisita_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max(cast(ID_V as varchar)),0)+1 from VISITANTES", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtID.Text = dt.Rows[0][0].ToString();

            con.Close();
        }
    }
}
