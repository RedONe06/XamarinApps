using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using XAMLApp.Models;

namespace XAMLApp.Data
{
    public class AgendamentoDAO
    {
        private readonly SQLiteConnection _conexao;

        private List<Agendamento> _lista;

        public List<Agendamento> Lista
        {
            get { return _conexao.Table<Agendamento>().ToList(); }
            set { _lista = value; }
        }

        public AgendamentoDAO(SQLiteConnection conexao)
        {
            this._conexao = conexao;
            this._conexao.CreateTable<Agendamento>();
        }

        public void Salvar(Agendamento agendamento)
        {
            _conexao.Insert(agendamento);
        }
    }
}
