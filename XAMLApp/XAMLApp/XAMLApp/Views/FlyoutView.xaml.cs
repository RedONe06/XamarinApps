using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAMLApp.Models;
using XAMLApp.ViewModels;

namespace XAMLApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutView : TabbedPage
    {
        public FlyoutView(Usuario usuario)
        {
            InitializeComponent();
            this.BindingContext = new FlyoutViewModel(usuario);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


            AssinarMensagens();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            CancelarMensagens();
        }

        private void CancelarMensagens()
        {
            MessagingCenter.Unsubscribe<Usuario>(this, "EditarPerfil");
            MessagingCenter.Unsubscribe<Usuario>(this, "SucessoSalvarPerfil");
        }

        private void AssinarMensagens()
        {
            MessagingCenter.Subscribe<Usuario>(this, "EditarPerfil", (msg) =>
            {
                this.CurrentPage = this.Children[1];
            });

            MessagingCenter.Subscribe<Usuario>(this, "SucessoSalvarPerfil", (msg) =>
            {
                this.CurrentPage = this.Children[0];
            });
        }
    }
}