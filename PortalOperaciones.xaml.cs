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
    /// Lógica de interacción para PortalOperaciones.xaml
    /// </summary>
    public partial class PortalOperaciones : Window
    {
        string miConexion = ConfigurationManager.ConnectionStrings["AccountantManager.Properties.Settings.LoginConnectionString"].ConnectionString;
        public PortalOperaciones()
        {
            InitializeComponent();
            DataClasses2DataContext miContexto = new DataClasses2DataContext(miConexion);
            DGTrabajos.Items.Add(miContexto.Trabajos.ToList());


        }
    }
}
