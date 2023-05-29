using Confiho.MVVM.Model;
using Confiho.MVVM.ViewModel;
using Mopups.Services;

namespace Confiho.MVVM.View;

public partial class AddCostPage
{
	public AddCostPage(String Admin)
	{
		InitializeComponent();
		BindingContext = new AddCostVM(Admin);
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
                // Se seleccion� un archivo
                string fileName = fileResult.FileName;
                FilePathEntry.Text = fileName;
                // Realiza las acciones necesarias con el archivo
            }
            else
            {
                // No se seleccion� ning�n archivo
            }
        }
        catch (Exception ex)
        {
            // Maneja cualquier excepci�n que pueda ocurrir durante la selecci�n del archivo
            Console.WriteLine($"Error al seleccionar el archivo: {ex.Message}");
        }
    }
}