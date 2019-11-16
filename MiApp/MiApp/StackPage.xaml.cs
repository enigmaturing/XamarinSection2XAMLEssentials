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
    public partial class StackPage : ContentPage
    {
        public StackPage()
        {
            InitializeComponent();

            var layout = new StackLayout
            {
                Spacing = 40,
                Padding = new Thickness(0, 20, 0, 0),
                Orientation = StackOrientation.Vertical
            };

            layout.Children.Add(new Label {  Text = "Label 1" });
            layout.Children.Add(new Label { Text = "Label 1" });
            layout.Children.Add(new Label { Text = "Label 1" });
            layout.Children.Add(new Label { Text = "Label 1" });
            layout.Children.Add(new Label { Text = "Label 1" });
            layout.Children.Add(new Label { Text = "Label 1" });


            // Muy importante, no olvidar la siguiente línea, que es
            // en la que fijamos el contenido del layout
            Content = layout;
        }
    }
}