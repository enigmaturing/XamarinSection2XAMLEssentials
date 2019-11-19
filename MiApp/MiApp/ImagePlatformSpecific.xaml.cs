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
    public partial class ImagePlatformSpecific : ContentPage
    {
        public ImagePlatformSpecific()
        {
            InitializeComponent();
            button.ImageSource = (FileImageSource) ImageSource.FromFile("clock.png");
        }
    }
}