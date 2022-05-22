using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AccountantManager
{
    /// <summary>
    /// Lógica de interacción para Login_Menu.xaml
    /// </summary>
    public partial class Login_Menu : Window
    {
        //Conexion sql a utilizar mas adelante
        //SqlConnection miConexionSql;

        //Verificador de Ingreso Campo de Clase.
        public bool ingresoCorrecto = false;

        //Cadena de conexion a utilizar
        string miConexion = ConfigurationManager.ConnectionStrings["AccountantManager.Properties.Settings.LoginConnectionString"].ConnectionString;

        public Login_Menu()
        {
            InitializeComponent(); 
        }

        public bool ingresoOK()
        {
            return ingresoCorrecto;
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            
            // Ejemplo Login: https://rjcodeadvance.com/cap-2-login-logout-y-mostrar-datos-del-usuario-validaciones-con-arquitectura-en-capas-poo-c-y-mysql-nivel-intermedio/
            if ( (TBUsuario.Text != "") && (PBPass.Password!="") )
            {
                string consultaLogin = "SELECT Pass FROM TableLogin WHERE  TableLogin.Nombre = @usuario";

                using (SqlConnection connect = new SqlConnection(miConexion))
                {
                    SqlCommand cmd = new SqlCommand(consultaLogin, connect);
                    cmd.Parameters.AddWithValue("@usuario", TBUsuario.Text);
                    connect.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    //Comprobamos que ingresamos el usuario correcto
                    {
                        reader.Read();
                        if (PBPass.Password == reader.GetString(0))
                        {
                            this.ingresoCorrecto = true;
                            this.Visibility = Visibility.Hidden;
                        }
                    }
                    else
                    { 
                        MessageBox.Show("Contraseña o Usuario Incorrecto!. Por favor pruebe nuevamente.");
                        TBUsuario.Clear();
                        PBPass.Clear();
                    }
                    connect.Close();
                }
             }
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e) =>LblOlvido.FontSize = 11;
        private void LblOlvido_MouseLeave(object sender, MouseEventArgs e) => LblOlvido.FontSize = 10;
        

        private void ActualizarContraseña(string usuario, string nuevaContraseña)
        {
            string consulta =  "UPDATE TableLogin SET Pass = @nuevaContraseña WHERE TableLogin.Nombre = @usuario";
            try{
                using(SqlConnection connect = new SqlConnection(miConexion))
                {
                    SqlCommand cmd = new SqlCommand(consulta,connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@nuevaContraseña",nuevaContraseña);
                    cmd.Parameters.AddWithValue("@usuario",usuario);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                }
            }catch (Exception e)
            {
                MessageBox.Show("Ocurrio un problema al actualizar la contraseña! ");
            }

        }
    }
}
