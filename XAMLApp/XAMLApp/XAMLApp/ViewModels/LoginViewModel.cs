using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XAMLApp.Models;
using XAMLApp.Services;

namespace XAMLApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private LoginService _loginService;
        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged();
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
                OnPropertyChanged();
                ((Command)EntrarCommand).ChangeCanExecute();
            }
        }

        public ICommand EntrarCommand { get; set; }

        public LoginViewModel()
        {
            EntrarCommand = new Command(() =>
            {
                var loginService = new LoginService();
                loginService.FazerLogin(new Login(email, password));
            }, () =>
            {
                return !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password);
            });
        }
    }
}
