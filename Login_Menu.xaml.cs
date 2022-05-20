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
