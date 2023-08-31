using Xamarin.Forms;
using XAMLApp.Models;
using XAMLApp.Views;

namespace XAMLApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new LoginView();
        }

        protected override void OnStart()
        {
            MessagingCenter.Subscribe<Usuario>(this, "SucessoLogin", (msg) =>
            {
                // MainPage = new NavigationPage(new ListagemView());
                MainPage = new FlyoutPageView(msg);
            });
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
