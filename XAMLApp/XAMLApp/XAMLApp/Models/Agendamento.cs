using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace XAMLApp.Models
{
    public class Agendamento
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Modelo { get; set; }
        public decimal Preco { get; set; }

        DateTime dataAgendamento = DateTime.Today;
        public DateTime DataAgendamento
        {
            get
            {
                return dataAgendamento;
            }
            set
            {
                dataAgendamento = value;
            }
        }
        public TimeSpan HoraAgendamento { get; set; }

        public Agendamento(string nome, string telefone, string email, string modelo, decimal preco)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Modelo = modelo;
            Preco = preco;
        }
    }
}
