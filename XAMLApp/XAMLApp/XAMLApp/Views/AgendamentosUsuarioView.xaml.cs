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
    public partial class AgendamentosUsuarioView : ContentPage
    {
        readonly AgendamentosUsuarioViewModel _viewModel;
        public AgendamentosUsuarioView()
        {
            InitializeComponent();
            this._viewModel = new AgendamentosUsuarioViewModel();
            this.BindingContext = this._viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            AssinarMensagens();
        }

        private void AssinarMensagens()
        {
            MessagingCenter.Subscribe<Agendamento>(this, "AgendamentoSelecionado", async (msg) =>
            {
                var confirma = await DisplayAlert("Reenviar", "Deseja reenviar o agendamento?", "Sim", "Não");

                if (confirma)
                {
                    MessagingCenter.Send<Agendamento>(msg, "ReenviarAgendamento");
                }
            });

            MessagingCenter.Subscribe<Agendamento>(this, "ReenviarAgendamento", async (msg) =>
            {
                await DisplayAlert("Agendamento",
            string.Format("Nome: {0}\nFone: {1}\nE-mail: {2}\nVeículo: {3}\nData Agendamento: {4}\nHora Agendamento: {5}", msg.Nome, msg.Telefone, msg.Email, msg.Modelo, msg.DataAgendamento.ToString("dd/MM/yyyy"), msg.HoraAgendamento.ToString()), "Ok");
                await Navigation.PopToRootAsync();
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            DessassinarMensagens();
        }

        private void DessassinarMensagens()
        {
            MessagingCenter.Unsubscribe<Agendamento>(this, "AgendamentoSelecionado");
            MessagingCenter.Unsubscribe<Agendamento>(this, "ReenviarAgendamento");
        }
    }
}