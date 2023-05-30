using Confiho.MVVM.Model;
using Confiho.MVVM.View;
using Confiho.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Confiho.MVVM.ViewModel
{
    public class LoginVM
    {
        public string email { get; set; }
        public string password { get; set; }

        public ICommand AuthenticationCommand =>
            new Command(async () =>
            {
                var url = $"{Credentials.getInstance().baseUrl}/users/auth/";
                var login = new Model.Login
                {
                    email = email,
                    password = password
                };
                string json = JsonSerializer.Serialize<Model.Login>(login, Credentials.getInstance()._serializerOptions);

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await Credentials.getInstance().client.PostAsync(url, content);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync())
                    {
                        using (var streamReader = new StreamReader(responseStream))
                        {
                            string responseBody = await streamReader.ReadToEndAsync();
                            if (responseBody != "null")
                            {
                                Session data = JsonSerializer.Deserialize<Session>(responseBody);
                                SessionService.getInstance().Session = data;
                                email = "";
                                password = "";
                                await App.MainVM.getPresupuesto();
                                await Shell.Current.GoToAsync($"//{nameof(Main)}");
                            }
                            else
                            {
                                await Application.Current.MainPage.DisplayAlert("Error ;(", "Datos incorrectos", "Ok");
                            }
                        }
                    }
                }
            });

    }
}
