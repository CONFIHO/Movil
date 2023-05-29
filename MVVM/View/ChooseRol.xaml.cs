namespace Confiho.MVVM.View;

public partial class ChooseRol : ContentPage
{
	public ChooseRol()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(Register)}?rolName=Consumidor");
    }

    private void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(Register)}?rolName=Administrador");
    }
}