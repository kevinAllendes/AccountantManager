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

namespace AccountantManager
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Login_Menu MiLogin = new Login_Menu();
            MiLogin.ShowDialog();
            if (! MiLogin.ingreso) this.Close(); 
            else MiLogin.Close();
            //if(!MiLogin.ingresoOK())this.Close();
            //else MiLogin.Close();
        }
    }

    class Cliente
    //Esto es una clase que define a un cliente del A
    //Describe sus caracteristicas y su funcionalidad
    {
        char[] CATEGORIAS = new char[10] {'A','B','C','D','F','G','H','I','J','K'};

        string nombre_razonSocial,email;
        int Cuil_Cuit;
        Char categoriaActual;

        public string NOMBRE_COMPLETO
        {
            get {return this.nombre_razonSocial;}
            set {this.nombre_razonSocial = value;}
        }
        public Char MICATEGORIA
        {
            get {return this.categoriaActual;}
            set {
                if(CATEGORIAS.Contains(value)) this.categoriaActual= value; 
            }
        }

        public int MICUIL_CUIT
        {
            get {return this.Cuil_Cuit;}
            set {
                if(value>0) this.Cuil_Cuit = value;
            }
        }

        public string CORREO
        {
            get {return this.email;}
            set {
                if(value.Contains('@')) this.email = value;
            }
        }

    }
}
