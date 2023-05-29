using Confiho.MVVM.Model;
using Confiho.Services;
using PropertyChanged;
using System.Text;
using System.Text.Json;
using System.Windows.Input;

namespace Confiho.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class RegisterVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Rol { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfPass { get; set; }

        public ICommand AddUserCommand =>
            new Command(async () =>
            {
                var url = $"{Credentials.getInstance().baseUrl}/users/";
                var user = new User
                {
                    rol_id = Rol == "Consumidor" ? 2 : 1,
                    name = FirstName + " " + LastName,
                    email = Email,
                    password = Password
                };
                string json = JsonSerializer.Serialize<User>(user, Credentials.getInstance()._serializerOptions);

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await Credentials.getInstance().client.PostAsync(url, content);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    await Application.Current.MainPage.DisplayAlert("Exito :)", "Usuario creado con exito", "Ok");
                    await Shell.Current.GoToAsync($"//{nameof(View.Login)}");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error ;(", "Usuario no se creo con exito verifique la informacion", "Ok");
                }
            });


    }
}
