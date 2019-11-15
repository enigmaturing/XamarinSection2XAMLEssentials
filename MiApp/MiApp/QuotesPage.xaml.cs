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
    public partial class QuotesPage : ContentPage
    {
        private string[] quotes = new string[5] {"You can't blame the gravity for falling in love", 
                                                 "Perro ladrador, poco mordedor",
                                                 "A quien madruga, dios le ayuda",
                                                 "No dejes para mañana lo que puedes hacer hoy",
                                                 "A quién buen árbole se arrima, buena sombra le cobija"};
        private int activeQuote = 0;

        public QuotesPage()
        {
            InitializeComponent();
            quoteText.Text = quotes[activeQuote];
        }

        private void buttonNext_Clicked(object sender, EventArgs e)
        {
            if(activeQuote < quotes.Length - 1)
            {
                activeQuote++;
            }
            else
            {
                activeQuote = 0;
            }
            quoteText.Text = quotes[activeQuote];
        }
    }
}