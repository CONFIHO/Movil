namespace Confiho.MVVM.View;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void Button_Pressed(object sender, EventArgs e)
    {
		ButtonLogin.BackgroundColor = Colors.BlueViolet;
        ButtonLogin.TextColor = Colors.White;
    }

    private void Button_Pressed_1(object sender, EventArgs e)
    {
        ButtonRegister.BackgroundColor = Colors.Purple;
        ButtonRegister.TextColor = Colors.White;
    }

    private void ButtonLogin_Released(object sender, EventArgs e)
    {
        ButtonLogin.BackgroundColor = Colors.Transparent;
        ButtonLogin.TextColor = Colors.BlueViolet;
    }

    private void ButtonRegister_Released(object sender, EventArgs e)
    {
        ButtonRegister.BackgroundColor = Colors.Transparent;
        ButtonRegister.TextColor = Colors.Purple;
    }

    private void ButtonRegister_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(Register)}");
    }

    private void ButtonLogin_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(Main)}");
    }
}