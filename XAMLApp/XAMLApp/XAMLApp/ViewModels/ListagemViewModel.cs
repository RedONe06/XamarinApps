using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using XAMLApp.Models;

namespace XAMLApp.ViewModels
{
    public class ListagemViewModel : BaseViewModel
    {
        const string URL_GET_VEICULOS = "https://brasilapi.com.br/api/fipe/marcas/v1/carros";
        public ObservableCollection<Veiculo> Veiculos { get; set; }
        Veiculo veiculoSelecionado { get; set; }
        public Veiculo VeiculoSelecionado
        {
            get
            {
                return veiculoSelecionado;
            }
            set
            {
                veiculoSelecionado = value;
                if (value != null)
                {
                    MessagingCenter.Send(veiculoSelecionado, "VeiculoSelecionado");
                }
            }
        }

        private bool aguarde;

        public bool Aguarde
        {
            get { return aguarde; }
            set 
            {
                aguarde = value;
                OnPropertyChanged();
            }
        }


        public ListagemViewModel()
        {
            this.Veiculos = new ObservableCollection<Veiculo>();
        }

        public async Task GetVeiculos()
        {
            Aguarde = true;
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync(URL_GET_VEICULOS);
            var veiculos = JsonConvert.DeserializeObject<ObservableCollection<Veiculo>>(result);
            foreach(var veiculo in veiculos)
            {
                this.Veiculos.Add(new Veiculo
                {
                    Nome = veiculo.Nome,
                    Preco = veiculo.Preco
                });
            }
            Aguarde = false;
        }
    }
}
