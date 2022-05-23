using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace AccountantManager
{
    /// <summary>
    /// Lógica de interacción para FormAgregarCliente.xaml
    /// </summary>
    public partial class FormAgregarCliente : Window
    {
        List<Char> Categorias = new List<Char>() { 'A', 'B', 'C', 'D', 'F', 'G', 'H', 'I', 'J', 'K', 'N' };
        string miConexion = ConfigurationManager.ConnectionStrings["AccountantManager.Properties.Settings.LoginConnectionString"].ConnectionString;
        public FormAgregarCliente()
        {
            CBCategorias.ItemsSource = Categorias;
            InitializeComponent();
        }

        public void Agregar(string nombre_razon, string correo, int cuilCuit, char categ)
        {
            //La categoria N define a  un asalariao que no es monotributista
            if ((nombre_razon != "") && (correo.Contains('@')) && (cuilCuit != 0) && (Categorias.Contains(categ)))
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
            Agregar(TBNombre.Text, TBEmail.Text, Int32.Parse(TBCuilCuit.Text), CBCategorias.SelectedItem.ToString()[0]);
        }

        private void RBEsMonotributista_Checked(object sender, RoutedEventArgs e)
        {
            CBCategorias.IsEnabled = true;
        }
    }
}
