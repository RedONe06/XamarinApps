using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAMLApp.Models;

namespace XAMLApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgendamentoView : ContentPage
    {
        public Agendamento Agendamento { get; set; }
        public Veiculo Veiculo { get => Agendamento.Veiculo; set => Agendamento.Veiculo = value; }
        public string Nome { get => Agendamento.Nome; set => Agendamento.Nome = value; }
        public string Telefone { get => Agendamento.Telefone; set => Agendamento.Telefone = value; }
        public string Email { get => Agendamento.Email; set => Agendamento.Email = value; }
        public DateTime DataAgendamento { get => Agendamento.DataAgendamento; set => Agendamento.DataAgendamento = value; }
        public TimeSpan HoraAgendamento { get => Agendamento.HoraAgendamento; set => Agendamento.HoraAgendamento = value; }

        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            this.Agendamento = new Agendamento();
            Agendamento.Veiculo = veiculo;
            this.BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento",
                string.Format("Nome: {0}\nFone: {1}\nE-mail: {2}\nVeículo: {3}\nData Agendamento: {4}\nHora Agendamento: {5}", Nome, Telefone, Email, Veiculo.Nome, DataAgendamento.ToString("dd/MM/yyyy"), HoraAgendamento), "Ok");
        }
    }
}