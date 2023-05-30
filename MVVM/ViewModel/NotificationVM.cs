using Confiho.MVVM.Model;
using Confiho.Services;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Confiho.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class NotificationVM
    {
        public ObservableCollection<Vinculations> vinculations { get; set; }

        public async Task<bool> getVinculations()
        {
            var url = $"{Credentials.getInstance().baseUrl}/budgets/all/{SessionService.getInstance().Session.id}?status=PENDIENTE";
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    using (var streamReader = new StreamReader(responseStream))
                    {
                        string responseBody = await streamReader.ReadToEndAsync();
                        if (responseBody != "null")
                        {
                            ObservableCollection<Vinculations> data = JsonSerializer.Deserialize<ObservableCollection<Vinculations>>(responseBody);
                            vinculations = data;
                        }
                        else
                        {
                            await Application.Current.MainPage.DisplayAlert("Error ;(", "No se encontraron datos", "Ok");
                        }
                    }
                }
            }
            return true;
        }
    }
}
