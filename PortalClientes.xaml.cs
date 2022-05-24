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
    /// Lógica de interacción para PortalClientes.xaml
    /// </summary>
    public partial class PortalClientes : Window
    {
        List<Char> Categorias = new List<Char>() { 'A', 'B', 'C', 'D', 'F', 'G', 'H', 'I', 'J', 'K', 'N' };
        string miConexion = ConfigurationManager.ConnectionStrings["AccountantManager.Properties.Settings.LoginConnectionString"].ConnectionString;
        public PortalClientes()
        {
            InitializeComponent();
            RellenarTablaClientes();

        }

        private void RellenarTablaClientes()
        {
            DataClasses1DataContext miContexto;
            miContexto = new DataClasses1DataContext(miConexion);
            //DGClientes.SelectedValuePath = "IDCliente";
            DGClientes.ItemsSource = miContexto.Clientes;

        }

        private void EliminarCliente()
        {
            /*
                Ejemplo captura de un dato de una celda
            */
            //Devuelve la fila completa seleccionada

            //Establecemos la conexión del dbml con la base de datos
            DataClasses1DataContext dataContext;
            dataContext = new DataClasses1DataContext(miConexion);

            Clientes clienteABorrar = (Clientes)DGClientes.SelectedItem;
            // int index = DGClientes.CurrentCell.Column.DisplayIndex;
            string cellValue = clienteABorrar.Nombre_RazonSocial.ToString();

            MessageBox.Show("Se eliminara este registro: " + cellValue);
            //Eliminamos el cliente

            Clientes ABorrar = dataContext.Clientes.First(cli => cli.Nombre_RazonSocial.Equals(cellValue));
            dataContext.Clientes.DeleteOnSubmit(ABorrar);
            dataContext.SubmitChanges();

            //Se Actualiza tabla clientes
            RellenarTablaClientes();


        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            EliminarCliente();
        }

        private void ActualizarMiStatusBar()
        {

        }

        private void BtnEliminar_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAgregarCliente_Click(object sender, RoutedEventArgs e)
        {
            FormAgregarCliente miFormAgregar = new FormAgregarCliente();
            miFormAgregar.ShowDialog();
            //Actualizamos!. 
            RellenarTablaClientes();

        }
    }
}
