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
    public partial class Ejercicio2_Video24_Stacklayout : ContentPage
    {
        public Ejercicio2_Video24_Stacklayout()
        {
            InitializeComponent();
        }

        private void likeButton_Clicked(object sender, EventArgs e)
        {
            likeText.IsVisible = true;
            commentsText.IsVisible = false;
            shareText.IsVisible = false;
        }

        private void likeComment_Clicked(object sender, EventArgs e)
        {
            likeText.IsVisible = false;
            commentsText.IsVisible = true;
            shareText.IsVisible = false;
        }

        private void shareButton_Clicked(object sender, EventArgs e)
        {
            likeText.IsVisible = false;
            commentsText.IsVisible = false;
            shareText.IsVisible = true;
        }
    }
}