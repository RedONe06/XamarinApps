using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAMLApp.Models;
using XAMLApp.ViewModels;

namespace XAMLApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalhesView : ContentPage
    {
        public Veiculo Veiculo { get; private set; }
        public Usuario Usuario { get; private set; }
        public DetalhesView(Veiculo veiculo, Usuario usuario)
        {
            InitializeComponent();
            this.Veiculo = veiculo;
            this.Usuario = usuario;
            this.BindingContext = new DetalheViewModel(veiculo);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Veiculo>(this, "Proximo", (msg) => Navigation.PushAsync(new AgendamentoView(msg, this.Usuario)));
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Veiculo>(this, "Proximo");
        }
    }
}