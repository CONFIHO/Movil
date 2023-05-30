using Confiho.MVVM.Model;
using Confiho.MVVM.ViewModel;
using Mopups.Services;

namespace Confiho.MVVM.View;

public partial class Main : ContentPage
{
    Presupuesto current;
    IList<Presupuesto> presupuestos;

    public Main()
	{
		InitializeComponent();

        BindingContext = App.MainVM;
        if (collectionView.ItemsSource != null)
        {
            presupuestos = collectionView.ItemsSource as IList<Presupuesto>;
            current = presupuestos[0];
        }
	}

    private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
		collectionView.ScrollTo(e.CenterItemIndex);
        current = presupuestos[e.CenterItemIndex];
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PushAsync(new AddCostPage(current.admin_nickname, current.budget_history.id));
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        MopupService.Instance.PushAsync(new Stadistics(current));
    }
}