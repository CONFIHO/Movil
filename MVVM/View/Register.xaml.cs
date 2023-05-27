namespace Confiho.MVVM.View;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		epassword.IsPassword = epassword.IsPassword?false:true;
    }

    private void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        econfpassword.IsPassword = econfpassword.IsPassword ? false : true;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(Login)}");
    }
}