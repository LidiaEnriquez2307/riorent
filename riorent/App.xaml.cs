using System;


namespace riorent
{
    using Xamarin.Forms;
    using Views;
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            this.MainPage = new NavigationPage(new LoginPage());
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
