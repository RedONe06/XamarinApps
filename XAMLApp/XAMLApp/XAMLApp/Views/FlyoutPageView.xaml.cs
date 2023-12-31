﻿using System;
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

        protected override void OnAppearing()
        {
            base.OnAppearing();
            AssinarMensagens();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            CancelarAssinatura();
        }

        private void CancelarAssinatura()
        {
            MessagingCenter.Unsubscribe<Usuario>(this, "MeusAgendamentos");

            MessagingCenter.Unsubscribe<Usuario>(this, "NovoAgendamento");
        }

        private void AssinarMensagens()
        {
            MessagingCenter.Subscribe<Usuario>(this, "TodosAgendamentos", (msg) =>
            {
                this.Detail = new NavigationPage(new AgendamentosUsuarioView());
                this.IsPresented = false;
            });

            MessagingCenter.Subscribe<Usuario>(this, "NovoAgendamento", (msg) =>
            {
                this.Detail = new NavigationPage(new ListagemView(msg));
                this.IsPresented = false;
            });
        }
    }
}