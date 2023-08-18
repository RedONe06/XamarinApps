using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMLApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalhesView : ContentPage
	{
		public Veiculo Veiculo { get; set; }
		public DetalhesView (Veiculo veiculo)
		{
			InitializeComponent ();
			this.Veiculo = veiculo;
			this.BindingContext = this;
		}

        private void buttonProximo_Clicked(object sender, EventArgs e)
        {
			
			Navigation.PushAsync(new XAMLApp.Views.AgendamentoView(this.Veiculo));
        }
    }
}