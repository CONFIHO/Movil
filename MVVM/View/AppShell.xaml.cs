using Confiho.Services;
using Mopups.Services;

namespace Confiho.MVVM.View;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        BindingContext = SessionService.getInstance();
		Routing.RegisterRoute(nameof(Main), typeof(Main));
	}

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync($"//{nameof(Login)}");
    }

    private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
    {
        Shell.Current.SetValue(Shell.FlyoutIsPresentedProperty, false);
        MopupService.Instance.PushAsync(new NotificationPage());
    }
}