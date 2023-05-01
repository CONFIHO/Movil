using Confiho.MVVM.View;

namespace Confiho;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Login();
	}
}
