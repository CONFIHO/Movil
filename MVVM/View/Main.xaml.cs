using Confiho.MVVM.ViewModel;

namespace Confiho.MVVM.View;

public partial class Main : ContentPage
{
	public Main()
	{
		InitializeComponent();

		BindingContext = new PresupuestoVM();
	}

    private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
		collectionView.ScrollTo(e.CenterItemIndex);
    }
}