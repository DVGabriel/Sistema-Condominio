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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador(string NOMBRE)
        {
            InitializeComponent();
        }

        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
            string CADENA = "INSERT INTO USUARIO (ID_U,USUARIO,CONTRASEÑA,TIPO_USUARIO)  VALUES(@ID_U,@USUARIO,@CONTRASEÑA,@TIPO_USUARIO)";
            SqlCommand comando = new SqlCommand(CADENA, con);
            comando.Parameters.AddWithValue("@ID_U", txtID.Text);
            comando.Parameters.AddWithValue("@USUARIO", txtUsuario.Text);
            comando.Parameters.AddWithValue("@CONTRASEÑA", txtContraseña.Text);
            comando.Parameters.AddWithValue("@TIPO_USUARIO", comboTipoUser.Text);
            
            comando.ExecuteNonQuery();

            MessageBox.Show("Datos registrados");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
            SqlCommand comando = new SqlCommand("select ID_U,USUARIO,CONTRASEÑA,TIPO_USUARIO from USUARIO  ", con);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
            int flag = 0;
            string cadena = "Delete from USUARIO where ID_U ='" + txtID.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            flag = comando.ExecuteNonQuery();

            if (flag == 1)
            {

                MessageBox.Show("Datos Eliminados");
            }
            else
            {
                MessageBox.Show("No existe ese usuario");

            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
            int flag = 0;
            string cadena = "update USUARIO SET USUARIO='" + txtUsuario.Text + "',TIPO_USUARIO='" +comboTipoUser.Text + "',CONTRASEÑA='"+txtContraseña.Text+ "' WHERE ID_U='" + txtID.Text + "'";
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

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
            SqlCommand comando = new SqlCommand("select USUARIO_CONTROL, FECHA_ENTRADA_US,HORA_ENTRADA_US,HORA_SALIDA_US  from CONTROL_CONDOMINIO  " , con);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

            con.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
            con.Open();
           
            string cadena = "Delete from CONTROL_CONDOMINIO where USUARIO_CONTROL ='" +textBox1.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
             comando.ExecuteNonQuery();
              
                MessageBox.Show("Datos Limpiados");

          
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form C = new CerrarSesion();
            C.Show();
        }
    }
}
