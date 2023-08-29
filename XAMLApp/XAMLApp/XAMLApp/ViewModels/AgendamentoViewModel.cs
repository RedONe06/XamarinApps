using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XAMLApp.Models;

namespace XAMLApp.ViewModels
{
    public class AgendamentoViewModel
    {
        public Agendamento Agendamento { get; set; }
        public Veiculo Veiculo { get => Agendamento.Veiculo; set => Agendamento.Veiculo = value; }
        public string Nome { get => Agendamento.Nome; set => Agendamento.Nome = value; }
        public string Telefone { get => Agendamento.Telefone; set => Agendamento.Telefone = value; }
        public string Email { get => Agendamento.Email; set => Agendamento.Email = value; }
        public DateTime DataAgendamento { get => Agendamento.DataAgendamento; set => Agendamento.DataAgendamento = value; }
        public TimeSpan HoraAgendamento { get => Agendamento.HoraAgendamento; set => Agendamento.HoraAgendamento = value; }

        public AgendamentoViewModel(Veiculo veiculo)
        {
            this.Agendamento = new Agendamento();
            Agendamento.Veiculo = veiculo;
            AgendarCommand = new Command(() =>
            {
                MessagingCenter.Send<Agendamento>(this.Agendamento, "Agendamento");
            });
        }

        public ICommand AgendarCommand { get; set; }
    }
}
