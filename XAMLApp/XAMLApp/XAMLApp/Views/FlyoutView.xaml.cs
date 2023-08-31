using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAMLApp.Models;
using XAMLApp.ViewModels;

namespace XAMLApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutView : TabbedPage
    {
        public FlyoutView(Usuario usuario)
        {
            InitializeComponent();
            this.BindingContext = new FlyoutViewModel(usuario);
        }
    }
}