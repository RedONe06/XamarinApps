using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XAMLApp.Models;

namespace XAMLApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                ((Command)EntrarCommand).ChangeCanExecute();
            }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                ((Command)EntrarCommand).ChangeCanExecute();
            }
        }

        ICommand EntrarCommand { get; set; }

        public LoginViewModel()
        {
            EntrarCommand = new Command(() =>
            {
                MessagingCenter.Send<Usuario>(new Usuario(), "SucessoLogin");
            }, () =>
            {
                return !string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(password);
            });
        }
    }
}
