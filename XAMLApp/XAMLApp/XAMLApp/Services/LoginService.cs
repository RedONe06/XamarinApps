using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XAMLApp.Exceptions;
using XAMLApp.Models;

namespace XAMLApp.Services
{
    public class LoginService
    {
        public void FazerLogin(Login login)
        {
            /*
                             using(var cliente = new HttpClient()){
                                var camposFormulario = new FormUrlEncondedContent(new[] {
                                    new KeyValuePair<string, string>("email", this.Usuario);
                                    new KeyValuePair<string, string>("senha", this.Password);
                                });
                            cliente.BaseAddress = new Uri("endpoint.com");
                            await cliente.PostAsync("/login", camposFormulario);
                            };
                            */
            if (login.Password.Equals("Andriele@123") && login.Email.Equals("andriele@gmail.com"))
            {
                Usuario usuario = new Usuario()
                {
                    User = "Andriele Joras dos Santos",
                    Password = login.Password
                };

                MessagingCenter.Send<Usuario>(usuario, "SucessoLogin");
            }
            else
            {
                MessagingCenter.Send<LoginException>(new LoginException("Usuário ou senha incorretos."), "FalhaLogin");
            }
        }
    }
}
