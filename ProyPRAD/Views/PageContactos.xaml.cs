using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyPRAD.Models;
using ProyPRAD.Controllers;
using Plugin.Media;
using System.IO;
using SQLite;

namespace ProyPRAD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageContactos : ContentPage
    {

        Plugin.Media.Abstractions.MediaFile photo = null;
        public PageContactos()
        {
            InitializeComponent();
        }

        private Byte[] traeImagenByteArray()
        {
            if (photo != null)
            {
                using (MemoryStream memory = new MemoryStream())
                {
                    Stream stream = photo.GetStream();
                    stream.CopyTo(memory);
                    return memory.ToArray();
                }
            }
            return null;
        }

        private async void btnfoto_Clicked(object sender, EventArgs e)
        {
            photo = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "FotosApp",
                Name = "test.jpg",
                SaveToAlbum = true
            });

            if (photo != null)
            {
                Foto.Source = ImageSource.FromStream(() =>
                {
                   return photo.GetStream();
                });
                
            }
        }

        private void btSalvar_Clicked(object sender, EventArgs e)
        {
            if (photo == null)
                return;

            var site = new Sitios()
            {
                foto=traeImagenByteArray(),
                
 
            };

        }

        
    }
}