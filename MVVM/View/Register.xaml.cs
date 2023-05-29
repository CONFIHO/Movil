using Confiho.MVVM.ViewModel;

namespace Confiho.MVVM.View;
[QueryProperty(nameof(RolName), "rolName")]
public partial class Register : ContentPage
{
    string rolName;
    public string RolName
    {
        get => rolName;
        set
        {
            rolName = value;
            OnPropertyChanged();
            var x = BindingContext as RegisterVM;
            x.Rol = rolName;
        }
    }

    public Register()
	{
		InitializeComponent();
        BindingContext = new RegisterVM();
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