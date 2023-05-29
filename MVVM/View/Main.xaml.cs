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

		BindingContext = new MainVM();
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
        MopupService.Instance.PushAsync(new AddCostPage(current.admin_nickname));
    }
}