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

namespace AccountantManager
{
    /// <summary>
    /// Lógica de interacción para Buscar.xaml
    /// </summary>
    public partial class Buscar : Window
    {
        private string datoABuscar;
        public string DATOABUSCAR 
        {
            get { return datoABuscar; }
            set { this.datoABuscar = value; }

        }

        public Buscar(string lblText)
        {
            InitializeComponent();
            LblQBusco.Content = lblText;
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            this.DATOABUSCAR = TBBuscar.Text;
            this.Hide();


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
