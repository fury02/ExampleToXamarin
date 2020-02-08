using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ExampleToXamarin.IOC;

namespace ExampleToXamarin
{
    public partial class App : Application
    {
        public App()
        {
            DIContainer.Init();

            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
