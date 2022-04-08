using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyPRAD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListaSitios : ContentPage
    {
        public PageListaSitios()
        {
            InitializeComponent();
        }

        private void ListaSitios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}