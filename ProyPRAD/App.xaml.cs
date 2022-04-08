using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyPRAD.Controllers;
using System.IO;
using ProyPRAD.Views;

namespace ProyPRAD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DataBase.conexion(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DBPR.db3"));
            MainPage = new NavigationPage(new PagePrincipal());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
