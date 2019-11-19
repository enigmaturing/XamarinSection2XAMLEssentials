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
    public partial class ImageFromResources : ContentPage
    {
        public ImageFromResources()
        {
            InitializeComponent();
            // El String que le hemos de pasar al método FromSource tiene la siguiente forma:
            //NombredelAssembly.NombreDeLaCarpetaDondeEstaLaImagen.NombreDeLaImagen
            image.Source = ImageSource.FromResource("MiApp.Images.background.jpg");
        }
    }
}