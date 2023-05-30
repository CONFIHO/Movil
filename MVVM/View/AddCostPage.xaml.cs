using Confiho.MVVM.Model;
using Confiho.MVVM.ViewModel;
using Mopups.Services;

namespace Confiho.MVVM.View;

public partial class AddCostPage
{
	public AddCostPage(String Admin, int id_budget)
	{
		InitializeComponent();
		BindingContext = new AddCostVM(Admin, id_budget);
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }

    private async void Button_Clicked_1Async(object sender, EventArgs e)
    {
        try
        {
            FileResult fileResult = await FilePicker.PickAsync();
            if (fileResult != null)
            {
                // Se seleccionó un archivo
                string fileName = fileResult.FileName;
                FilePathEntry.Text = fileName;
                AddCostVM vm = BindingContext as AddCostVM;
                vm.Gasto.file_name = fileName;
            }
            else
            {
                // No se seleccionó ningún archivo
            }
        }
        catch (Exception ex)
        {
            // Maneja cualquier excepción que pueda ocurrir durante la selección del archivo
            Console.WriteLine($"Error al seleccionar el archivo: {ex.Message}");
        }
    }
}