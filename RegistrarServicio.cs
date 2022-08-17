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
    public partial class RegistrarServicio : Form
    {
        public RegistrarServicio()
        {
            InitializeComponent();
        }

     
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
            string CADENA = "INSERT INTO SERVICIO (ID_S,NOMBRE,RUT,PERMISO,TIPO,HORA_ENTRADA,FECHA_ENTRADA)  VALUES(@ID_S,@NOMBRE,@RUT,@PERMISO,@TIPO,@HORA_ENTRADA,@FECHA_ENTRADA)";
            SqlCommand comando = new SqlCommand(CADENA, con);
            comando.Parameters.AddWithValue("@ID_S", txtID.Text);
            comando.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
            comando.Parameters.AddWithValue("@RUT", txtRut.Text);
            comando.Parameters.AddWithValue("@PERMISO", comboPermiso.Text);
            comando.Parameters.AddWithValue("@TIPO", comboTipo.Text);
            comando.Parameters.AddWithValue("@HORA_ENTRADA", txtHoraEntrada.Text);
            comando.Parameters.AddWithValue("@FECHA_ENTRADA", txtFechaEntrada.Text);
            comando.ExecuteNonQuery();

            MessageBox.Show("Datos registrados");
            con.Close(); 
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
            SqlCommand comando = new SqlCommand("select ID_S,NOMBRE,RUT,PERMISO,TIPO,HORA_ENTRADA,HORA_SALIDA,FECHA_ENTRADA  from SERVICIO  ", con);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

            con.Close();
        }

        private void RegistrarServicio_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max(cast(ID_S as varchar)),0)+1 from SERVICIO", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtID.Text = dt.Rows[0][0].ToString();

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
            int flag = 0;
            string cadena = "update SERVICIO SET HORA_SALIDA='" + txtHrsSalida.Text +  "' WHERE ID_S='" + txtidRetirada.Text +"'";
            SqlCommand comando = new SqlCommand(cadena, con);
            flag = comando.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show("Actualizado");

            }
            else
            {
                MessageBox.Show("No Existe ese Identificador");

            }
            con.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
            int flag = 0;
            string cadena = "update SERVICIO SET NOMBRE='" + txtNombre.Text + "',RUT='" + txtRut.Text + "',PERMISO='" + comboPermiso.Text + "',TIPO='" + comboTipo.Text + "',HORA_ENTRADA='" + txtHoraEntrada.Text +"',FECHA_ENTRADA='"+txtFechaEntrada.Text + "' WHERE ID_R='" + txtID.Text + "'";
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

       

        
    }
}
