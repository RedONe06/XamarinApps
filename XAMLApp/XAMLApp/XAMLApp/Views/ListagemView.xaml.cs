using System.Collections.Generic;
using Xamarin.Forms;
using XAMLApp.Models;
using XAMLApp.ViewModels;

namespace XAMLApp.Views
{
    public partial class ListagemView : ContentPage
    {
        public ListagemViewModel ViewModel { get; set; }
        public ListagemView()
        {
            InitializeComponent();
            this.ViewModel = new ListagemViewModel();
            this.BindingContext = this.ViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Veiculo>(this, "VeiculoSelecionado", (msg) =>
            {
                Navigation.PushAsync(new DetalhesView(msg));
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
