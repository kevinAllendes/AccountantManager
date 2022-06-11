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
using System.Data.Linq;

namespace ProcedimientosPortal
{
    //Este procedimiento agrega un nuevo cliente a la BDD
    public void AgregarCliente(string nombre_razon, string correo,int cuilCuit,char categ)
    {

        //SE agrega un comentario
        //La categoria N define a  un asalariao que no es monotributista
        char[] CATEGORIAS = new char[11] {'A','B','C','D','F','G','H','I','J','K','N'};

        if( (nombre_razon!="") && (correo.Contains('@')) && (cuilCuit!=0) && (CATEEGORIAS.Contains(categ) ) )
        {
            //mi conexion definida. 
            string miConexion = ConfigurationManager.ConnectionStrings["AccountantManager.Properties.Settings.LoginConnectionString"].ConnectionString;
        
            //Establecemos la conexión del dbml con la base de datos
            DataClases1DataContext dataContext;
            dataContext = new DataClases1DataContext(miConexion);
        
            //Definimos el nuevo cliente
            Clientes miNuevoCliente = new Clientes() {Nombre = nombre_razon, Email = correo,Cuil_Cuit = cuilCuit, Categoria = categ };

            dataContext.Clientes.InsertOnSubmit(miNuevoCliente);
            dataContext.SubmitChanges();

            MessageBox.Show("Usuario agregado correctamente!");
        }
        else MessageBox.Show("Datos Incorrectos!. ");
    }

}