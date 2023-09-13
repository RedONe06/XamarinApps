using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XAMLApp.Data;
using XAMLApp.Exceptions;
using XAMLApp.Models;

namespace XAMLApp.ViewModels
{
    public class AgendamentoViewModel : BaseViewModel
    {
        public Agendamento Agendamento { get; set; }
        public string Modelo
        {
            get => Agendamento.Modelo; set
            {
                Agendamento.Modelo = value;
                OnPropertyChanged();
                ((Command)AgendarCommand).ChangeCanExecute();
            }
        }

        public decimal Preco
        {
            get => Agendamento.Preco; set
            {
                Agendamento.Preco = value;
                OnPropertyChanged();
                ((Command)AgendarCommand).ChangeCanExecute();
            }
        }

        public string Nome
        {
            get => Agendamento.Nome; set
            {
                Agendamento.Nome = value;
                OnPropertyChanged();
                ((Command)AgendarCommand).ChangeCanExecute();
            }

        }
        public string Telefone
        {
            get => Agendamento.Telefone; set
            {
                Agendamento.Telefone = value;
                OnPropertyChanged();
                ((Command)AgendarCommand).ChangeCanExecute();
            }
        }
        public string Email
        {
            get => Agendamento.Email; set
            {
                Agendamento.Email = value;
                OnPropertyChanged();
                ((Command)AgendarCommand).ChangeCanExecute();
            }
        }

        public bool Confirmado
        {
            get => Agendamento.Confirmado; set
            {
                Agendamento.Confirmado = value;
            }
        }

        public DateTime DataAgendamento { get => Agendamento.DataAgendamento; set => Agendamento.DataAgendamento = value; }
        public TimeSpan HoraAgendamento { get => Agendamento.HoraAgendamento; set => Agendamento.HoraAgendamento = value; }

        public AgendamentoViewModel(Veiculo veiculo, Usuario usuario)
        {
            this.Agendamento = new Agendamento(usuario.Nome, usuario.Telefone, usuario.Email, veiculo.Nome, veiculo.Preco, false);
            AgendarCommand = new Command(() =>
            {
                try
                {
                    this.Agendamento.Confirmado = true;
                    SalvarAgendamento(this.Agendamento.Confirmado);
                    MessagingCenter.Send<Agendamento>(this.Agendamento, "Agendamento");
                }
                catch (Exception ex)
                {
                    this.Agendamento.Confirmado = false;
                    SalvarAgendamento(this.Agendamento.Confirmado);
                    MessagingCenter.Send<AgendamentoException>(new AgendamentoException("Falha no agendamento, tente novamente mais tarde."), "FalhaAgendamento");
                }


            }, () =>
            {
                return !string.IsNullOrEmpty(this.Nome) && !string.IsNullOrEmpty(this.Telefone) && !string.IsNullOrEmpty(this.Email);
            });
        }

        public ICommand AgendarCommand { get; set; }

        public void SalvarAgendamento(bool confirmado)
        {
            using (var conexao = DependencyService.Get<ISQLite>().PegarConexao())
            {
                AgendamentoDAO dao = new AgendamentoDAO(conexao);
                dao.Salvar(new Agendamento(Nome, Telefone, Email, Modelo, Preco, confirmado));
            };
        }
    }
}
