using System.Collections.Generic;
using Xamarin.Forms;
using XAMLApp.Models;
using XAMLApp.ViewModels;

namespace XAMLApp.Views
{
    public partial class ListagemView : ContentPage
    {
        public ListagemViewModel ViewModel { get; set; }
        public Usuario Usuario { get; set; }
        public ListagemView(Usuario usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
            this.ViewModel = new ListagemViewModel();
            this.BindingContext = this.ViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Veiculo>(this, "VeiculoSelecionado", (msg) =>
            {
                Navigation.PushAsync(new DetalhesView(msg, Usuario));
            });
            this.ViewModel.GetVeiculos();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Veiculo>(this, "VeiculoSelecionado");
        }
    }
}
