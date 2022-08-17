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
    public partial class IniciarSesion : Form
    {
        private Timer ti;
        public IniciarSesion() {

            ti = new Timer();
                ti.Tick += new EventHandler(eventoTimer);
                InitializeComponent();
                ti.Enabled = true;
        }

        private void eventoTimer(object sender, EventArgs e)
        {
           DateTime hoy = DateTime.Now;
           labelReloj.Text = hoy.ToString("hh:mm:ss tt");

           lblEntrada.Text = DateTime.Now.ToShortDateString();
        }
       
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
        public void logear(string USUARIO, string CONTRASEÑA) {

            try
            {
                 
                
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TIPO_USUARIO FROM USUARIO WHERE USUARIO = '" + USUARIO + "' AND CONTRASEÑA = " + CONTRASEÑA, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {

                    if (dt.Rows[0].ItemArray[0].ToString() == "CONSERJE")
                    {
                        new MenuConserje (dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0].ItemArray[0].ToString() == "ADMINISTRADOR")
                    {
                        new MenuAdministrador(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Cointraseña Incorrecta");
                }

            }

            catch
            {

            }
            finally
            {
                con.Close();

            }
        
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                logear(this.textBox1.Text, this.textBox2.Text);

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Gestor de Condominio;Integrated Security=True");
                con.Open();
                string CADENA = "INSERT INTO CONTROL_CONDOMINIO (USUARIO_CONTROL,FECHA_ENTRADA_US,HORA_ENTRADA_US)  VALUES(@USUARIO_CONTROL,@FECHA_ENTRADA_US,@HORA_ENTRADA_US)";
                SqlCommand comando = new SqlCommand(CADENA, con);
                comando.Parameters.AddWithValue("@USUARIO_CONTROL", textBox1.Text);
                comando.Parameters.AddWithValue("@FECHA_ENTRADA_US", lblEntrada.Text);
                comando.Parameters.AddWithValue("@HORA_ENTRADA_US", labelReloj.Text);

                comando.ExecuteNonQuery();

                con.Close();

            }
            catch  {
                MessageBox.Show("debes completar los campos");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
