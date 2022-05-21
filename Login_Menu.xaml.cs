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
        SqlConnection miConexionSql;

        //Cadena de conexion a utilizar
        string miConexion = ConfigurationManager.ConnectionStrings["AccountantManager.Properties.Settings.LoginConnectionString"].ConnectionString;

        public Login_Menu()
        {
            InitializeComponent();

            

            
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            /*
            https://rjcodeadvance.com/cap-2-login-logout-y-mostrar-datos-del-usuario-validaciones-con-arquitectura-en-capas-poo-c-y-mysql-nivel-intermedio/

            public bool Login(string user, string pass)
             {
               using (var connection = GetConnection())
                {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from users where (loginName=@user and password=@pass) or (Email=@user and password=@pass)";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                        {
                            UserCache.IdUser = reader.GetInt32(0); 
                            UserCache.LoginName = reader.GetString(1);
                            UserCache.Password = reader.GetString(2);
            UserCache.FirstName = reader.GetString(3); 
            UserCache.LastName = reader.GetString(4);
            UserCache.Position = reader.GetString(5);
            UserCache.Email = reader.GetString(6);
                 }
                      return true;
                   }
                   else
                  return false;
                   }
                 }
            }
            */
            if (TBUsuario.Text != "")
            {
                string consultaLogin = "SELECT Pass FROM TableLogin WHERE  Nombre="+TBUsuario.Text.ToString();

                using (SqlConnection connect = new SqlConnection(miConexion))
                {
                    SqlCommand cmd = new SqlCommand(consultaLogin, connect);
                    connect.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if(reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show(reader.GetString(1));
                        }
                        
                    }
                    else{ MessageBox.Show("No se pudo mostrar el elemento");}
                    connect.Close();
    
                }

            }
            MessageBox.Show("Debe ingresar algun valor");
        }
    }
}
