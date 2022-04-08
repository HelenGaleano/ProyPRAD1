using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyPRAD.Controllers;

namespace ProyPRAD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListaContactos : ContentPage
    {
        public PageListaContactos()
        {
            InitializeComponent();
        }


        private void SearchBar_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            var contacto = BindingContext as PageContactos;
            ListaContactos.BindingContext = contacto;

        }

        private void ListaContactos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection!=null)
            {
                Models.Contactos contacto = (Models.Contactos)e.CurrentSelection.FirstOrDefault();
               
            }
        }

        private void btnCompartir_Contacto_Clicked(object sender, EventArgs e)
        {

        }

        private void btnVerImagen_Clicked(object sender, EventArgs e)
        {

        }

        private void btnEliminarContacto_Clicked(object sender, EventArgs e)
        {
            
        }

        private void btnActualizarContacto_Clicked(object sender, EventArgs e)
        {

        }
    }
}