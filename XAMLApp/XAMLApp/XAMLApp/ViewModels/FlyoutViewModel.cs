using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XAMLApp.Models;

namespace XAMLApp.ViewModels
{
    public class FlyoutViewModel : BaseViewModel
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

        public string DataNascimento
        {
            get { return this._usuario.DataNascimento; }
            set { this._usuario.DataNascimento = value; }
        }

        public string Telefone
        {
            get { return this._usuario.Telefone; }
            set { this._usuario.Telefone = value; }
        }

        private bool editando = false;

        public bool Editando
        {
            get { return editando; }
            set
            {
                editando = value;
                OnPropertyChanged(nameof(Editando));
            }
        }

        private readonly Usuario _usuario;

        public ICommand EditarPerfilCommand { get; private set; }
        public ICommand EditarCommand { get; private set; }

        public ICommand SalvarCommand { get; private set; }

        public FlyoutViewModel(Usuario usuario)
        {
            this._usuario = usuario;
            DefinirComandos(usuario);
        }

        private void DefinirComandos(Usuario usuario)
        {
            EditarPerfilCommand = new Command(() =>
            {
                MessagingCenter.Send<Usuario>(usuario, "EditarPerfil");
            });

            SalvarCommand = new Command(() =>
            {
                this.Editando = false;
                MessagingCenter.Send<Usuario>(usuario, "SucessoSalvarPerfil");
            });

            EditarCommand = new Command(() =>
            {
                this.Editando = true;
            });
        }
    }
}
