using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAMLApp.Models;

namespace XAMLApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutPageView : FlyoutPage
    {
        private readonly Usuario _usuario;
        public FlyoutPageView(Usuario usuario)
        {
            InitializeComponent();
            this._usuario = usuario;
            this.Flyout = new FlyoutView(usuario);
            this.Detail = new NavigationPage(new ListagemView(usuario));
        }
    }
}