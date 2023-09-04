using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XAMLApp.Data;
using XAMLApp.Models;

namespace XAMLApp.ViewModels
{
    public class AgendamentosUsuarioViewModel : BaseViewModel
    {
        private ObservableCollection<Agendamento> _lista = new ObservableCollection<Agendamento>();
        public ObservableCollection<Agendamento> Lista
        {
            get
            {
                return _lista;
            }
            private set
            {
                _lista = value;
                OnPropertyChanged();
            }
        }

        public AgendamentosUsuarioViewModel()
        {
            using (var conexao = DependencyService.Get<ISQLite>().PegarConexao())
            {
                AgendamentoDAO dao = new AgendamentoDAO(conexao);
                var listaDB = dao.Lista;
                var query = listaDB.OrderBy(x => x.DataAgendamento).ThenBy(x => x.HoraAgendamento);
                this.Lista.Clear();
                foreach (var item in query)
                {
                    this.Lista.Add(item);
                }
            };

        }
    }
}
