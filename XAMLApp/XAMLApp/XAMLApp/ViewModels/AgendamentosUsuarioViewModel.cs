using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                this.Lista.Clear();
                foreach (var item in listaDB)
                {
                    this.Lista.Add(item);
                }
            };

        }
    }
}
