using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XAMLApp.Models;

namespace XAMLApp.ViewModels
{
    public class FlyoutViewModel
    {
		public string Nome
		{
			get { return this._usuario.Nome; }
			set { this._usuario.Nome = value; }
		}

		public string Email
		{
            get { return this._usuario.Email; }
            set { this._usuario.Email = value; }
        }

		private readonly Usuario _usuario;

        public ICommand EditarPerfilCommand { get; private set; }
        public FlyoutViewModel(Usuario usuario)
        {
            this._usuario = usuario;
            EditarPerfilCommand = new Command(() =>
            {

            });
        }

    }
}
