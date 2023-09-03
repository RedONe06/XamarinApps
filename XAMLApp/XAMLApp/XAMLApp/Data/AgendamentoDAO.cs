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
