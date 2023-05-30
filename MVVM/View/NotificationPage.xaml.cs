using Mopups.Services;

namespace Confiho.MVVM.View;

public partial class NotificationPage
{
	public NotificationPage()
	{
		InitializeComponent();
        BindingContext = App.NotificationVM;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}