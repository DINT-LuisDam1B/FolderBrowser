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
using System.IO;
using System.Windows.Forms;

namespace FolderBrowser
{
    /// <summary>
    /// Lógica de interacción para UserControlFolderBrowser.xaml
    /// </summary>
    public partial class UserControlFolderBrowser : System.Windows.Controls.UserControl
    {


        public UserControlFolderBrowser()
        {
            InitializeComponent();
            this.DataContext = this;
        }



        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Titulo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TituloProperty =
            DependencyProperty.Register("Titulo", typeof(string), typeof(UserControlFolderBrowser), new PropertyMetadata(""));



        public string Ruta
        {
            get { return (string)GetValue(RutaProperty); }
            set { SetValue(RutaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Ruta.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RutaProperty =
            DependencyProperty.Register("Ruta", typeof(string), typeof(UserControlFolderBrowser), new PropertyMetadata(""));

        private void ButtonSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            Ruta = AbrirDirectorio();
        }

        public string AbrirDirectorio()
        {
            string ruta = "";
            //Creamos un nuevo diálogo
            System.Windows.Forms.FolderBrowserDialog dialogo = new FolderBrowserDialog();

            //Mostramos el diálogo
            DialogResult resultado = dialogo.ShowDialog();

            //Comprobamos si el usuario ha pulsado el botón Aceptar
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                //Accedemos a la ruta seleccionada por el usuario
                ruta = dialogo.SelectedPath;
            }
            return ruta;
        }
    }
}
