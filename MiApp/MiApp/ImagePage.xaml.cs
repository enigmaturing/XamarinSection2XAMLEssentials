using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            // Asociamos la uri al tag image con nombre imageSource:
            var imageSource = new UriImageSource { Uri = new Uri("https://lorempixel.com/1920/1080/sports/7/") };
            imageSource.CachingEnabled = false;  // no guardar las imágenes descargadas en la caché del teléfono
            // imageSource.CacheValidity = TimeSpan.FromHours(1);  // borrar la imagen descargada de la caché después de una hora
            image.Source = imageSource;
        }
    }
}