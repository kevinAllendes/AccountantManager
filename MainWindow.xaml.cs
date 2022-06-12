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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data;

namespace AccountantManager
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Char> Categorias = new List<Char>() { 'A', 'B', 'C', 'D', 'F', 'G', 'H', 'I', 'J', 'K', 'N' };

        //mi conexion definida.
        string miConexion = ConfigurationManager.ConnectionStrings["AccountantManager.Properties.Settings.LoginConnectionString"].ConnectionString;
        public MainWindow()
        {
            InitializeComponent();
            
            //No Abrimos Loing menu
           // Login_Menu MiLogin = new Login_Menu();
            
            
            //********************************************
            //Deshabilitamos el Login.
            //MiLogin.ShowDialog();
            //if (! MiLogin.ingresoCorrecto) this.Close(); 
            //else MiLogin.Close();
            //********************************************
            
            //Rellenamos la tabla clientes

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            PortalClientes miPortalCliente = new PortalClientes();
            miPortalCliente.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            FormAgregarCliente miFormAgregarCliente = new FormAgregarCliente();
            miFormAgregarCliente.ShowDialog();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MIBuscarCliente_Click(object sender, RoutedEventArgs e)
        {
            Buscar buscadorCliente = new Buscar("Ingrese el Nombre del cliente");
            buscadorCliente.ShowDialog();
            if (buscadorCliente.DATOABUSCAR != null)
            {
                PortalClientes miPortalCliente = new PortalClientes(buscadorCliente.DATOABUSCAR);
                miPortalCliente.ShowDialog();
            }
            buscadorCliente.Close();

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            PortalOperaciones miPortal = new PortalOperaciones();
            miPortal.ShowDialog();
        }

        //Este procedimiento agrega un nuevo cliente a la BDD




    }
}
