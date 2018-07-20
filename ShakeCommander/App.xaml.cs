using System;
using Xamarin.Forms;
using ShakeCommander.Views;
using Xamarin.Forms.Xaml;
using OpenCvSharp;
using Plugin.Sensors;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ShakeCommander
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();
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
