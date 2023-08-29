using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAMLApp.Models;
using XAMLApp.ViewModels;

namespace XAMLApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgendamentoView : ContentPage
    {
        public AgendamentoViewModel ViewModel { get; set; }

        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            this.ViewModel = new AgendamentoViewModel(veiculo);
            this.BindingContext = this.ViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Agendamento>(this, "Agendamento", (msg) =>
            {
                DisplayAlert("Agendamento",
                string.Format("Nome: {0}\nFone: {1}\nE-mail: {2}\nVeículo: {3}\nData Agendamento: {4}\nHora Agendamento: {5}", msg.Nome, msg.Telefone, msg.Email, msg.Veiculo.Nome, msg.DataAgendamento.ToString("dd/MM/yyyy"), msg.HoraAgendamento.ToString()), "Ok");
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Agendamento>(this, "Agendamento");
        }
    }
}