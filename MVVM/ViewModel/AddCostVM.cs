using Confiho.MVVM.Model;
using PropertyChanged;
using System.Text;
using System.Text.Json;
using System.Windows.Input;
using Confiho.Services;
using Mopups.Services;

namespace Confiho.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class AddCostVM
    {
        public string Admin { get; set; }
        public Gasto Gasto { get; set; }
        public AddCostVM(string Admin, int id_budget)
        {
            this.Admin = Admin;
            this.Gasto = new Gasto
            {
                description = "",
                value = 0,
                file_name = "",
                fileData = null,
                date = DateTime.Now,
                category_id = 1,
                budget_id = id_budget
            };
        }

        public ICommand AddCostCommand =>
            new Command(async () =>
            {
                var url = $"{Credentials.getInstance().baseUrl}/expenses/";

                Gasto.category_id = Gasto.category_id + 1;
                Gasto.expense_date = Gasto.date.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");

                string json = JsonSerializer.Serialize<Gasto>(Gasto, Credentials.getInstance()._serializerOptions);

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
                                await Application.Current.MainPage.DisplayAlert("Exito :)", "Gasto creado con exito", "Ok");
                                await App.MainVM.getPresupuesto();
                                await MopupService.Instance.PopAsync();
                            }
                            else
                            {
                                await Application.Current.MainPage.DisplayAlert("Error ;(", "Gasto no se creo con exito verifique la informacion", "Ok");
                            }
                        }
                    }
                }
            });
    }
}
