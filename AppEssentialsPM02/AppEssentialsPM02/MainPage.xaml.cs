using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppEssentialsPM02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnTexto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SpeechPage   ());
        }

        private async void btnMapas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapPage());
        }

        private async void btnTomarFoto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FotoPage());
        }
    }
}
