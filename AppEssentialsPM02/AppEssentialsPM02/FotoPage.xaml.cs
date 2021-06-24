using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Media;
using Xamarin.Essentials;

namespace AppEssentialsPM02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FotoPage : ContentPage
    {
        public FotoPage()
        {
            InitializeComponent();
        }

        private async void toma_Clicked(object sender, EventArgs e)
        {
            //var tomarfoto = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions());
            var tomarfoto = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "MyApp",
                Name = "Prueba.jpg"
            });

            await DisplayAlert("Ubicacion Archivo", tomarfoto.Path, "Ok");

            if (tomarfoto != null)
            {
                foto.Source = ImageSource.FromStream(() => { return tomarfoto.GetStream(); });
            }

            var compartirFoto = tomarfoto.Path;
            await Share.RequestAsync(new ShareFileRequest
            {
                Title = "Foto",
                File = new ShareFile(compartirFoto)
            });
        }
    }
}