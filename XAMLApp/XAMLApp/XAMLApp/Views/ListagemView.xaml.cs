using System.Collections.Generic;
using Xamarin.Forms;
using XAMLApp.Models;

namespace XAMLApp.Views
{
    

    public partial class ListagemView : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }

        public ListagemView()
        {
            InitializeComponent();

            this.Veiculos = new ListagemVeiculos().Veiculos;
            this.BindingContext = this;
        }

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            Navigation.PushAsync(new Views.DetalhesView(veiculo));
        }
    }
}
