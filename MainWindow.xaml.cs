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
            CBCategorias.ItemsSource = Categorias;
            //Abrimos Loing menu
            Login_Menu MiLogin = new Login_Menu();
            
            //Prueba Child form
            
            //-------------


            //Cargamos DG con los clientes.
            DGClientes.ItemsSource = Categorias;
            MiLogin.ShowDialog();
            if (! MiLogin.ingresoCorrecto) this.Close(); 
            else MiLogin.Close();
            //Rellenamos la tabla clientes
            RellenarTablaClientes();

        }

        //Este procedimiento agrega un nuevo cliente a la BDD
        public void AgregarCliente(string nombre_razon, string correo, int cuilCuit, char categ)
        {
            //La categoria N define a  un asalariao que no es monotributista
            if ( (nombre_razon != "") && (correo.Contains('@')) && (cuilCuit != 0) && (Categorias.Contains(categ) ) )
            {
                //Establecemos la conexión del dbml con la base de datos
                DataClasses1DataContext dataContext;
                dataContext = new DataClasses1DataContext(miConexion);

                //Definimos el nuevo cliente
                Clientes miNuevoCliente = new Clientes() { Nombre_RazonSocial = nombre_razon, Email = correo, CUIL_CUIT = cuilCuit, Categoria = categ.ToString() };

                dataContext.Clientes.InsertOnSubmit(miNuevoCliente);
                dataContext.SubmitChanges();

                MessageBox.Show("Usuario agregado correctamente!");
            }
            else MessageBox.Show("Datos Incorrectos!. ");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AgregarCliente(TBNombre.Text, TBEmail.Text, Int32.Parse(TBCuilCuit.Text), CBCategorias.SelectedItem.ToString()[0]);
            RellenarTablaClientes();

        }

        private void RellenarTablaClientes()
        {
            DataClasses1DataContext miContexto;
            miContexto = new DataClasses1DataContext(miConexion);
            DGClientes.SelectedValuePath = "IDCliente";
            DGClientes.ItemsSource = miContexto.Clientes;
        }

        private void EliminarCliente()
        {
            var CelInfo = DGClientes.SelectedCells[0];
            MessageBox.Show(CelInfo.Column);
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            EliminarCliente();
        }
    }
}
