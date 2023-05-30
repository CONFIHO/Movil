using Confiho.MVVM.Model;
using Confiho.MVVM.ViewModel;
using Mopups.Services;

namespace Confiho.MVVM.View;

public partial class Stadistics
{
	public Stadistics(Presupuesto presupuesto)
	{
        StadisticsVM stadisticsVM = new StadisticsVM(presupuesto);
        stadisticsVM.GetTransactionsSummary();
        BindingContext = stadisticsVM;
        InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}