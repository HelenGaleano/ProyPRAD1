using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyPRAD.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyPRAD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        private  async void btn_contatos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageListaContactos());
         }

        private async void btn_places_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageListaSitios());
        }


        private async void btnsitiod_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageSitios());
        }

        private async void btnContactos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageContactos());
        }
    }
}