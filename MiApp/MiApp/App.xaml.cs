using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new QuotesPage();
            //MainPage = new StackPage();
            //MainPage = new Ejercicio2_Video24_Stacklayout();
            //MainPage = new GridPage();
            //MainPage = new Ejercicio1_Video27_GridLayout();
            //MainPage = new Ejercicio1_Video27_GridLayout();
            //MainPage = new Ejercicio2_Video27_GridLayout();
            //MainPage = new AbsoluteLayoutPage();
            //MainPage = new Ejercicio1_Video30_AbsoluteLayout();
            MainPage = new Ejercicio2_Video30_AbsoluteLayout();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
