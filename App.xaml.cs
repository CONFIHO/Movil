using Confiho.MVVM.View;
using Confiho.MVVM.ViewModel;

namespace Confiho;

public partial class App : Application
{
	public static MainVM MainVM { get; private set; } = new MainVM();
	public static NotificationVM NotificationVM { get; private set; } = new NotificationVM();
	public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHJqVk1mQ1NMaV1CX2BZf1F8RGBTe1tgFChNYlxTR3ZaQFRiS39UdEVjWHpd;Mgo+DSMBPh8sVXJ1S0R+X1pCaV1KQmFJfFBmRGFTfl16cFBWACFaRnZdQV1mS3dSdERkW39ec3RW;ORg4AjUWIQA/Gnt2VFhiQlJPcEBAVXxLflF1VWJbdV9zflFDcDwsT3RfQF5jTHxad0diXn1ecHBQRQ==;MjIzODcxMUAzMjMxMmUzMDJlMzBENFkzaFlxZ3ovT0d2VmVpejE1Q2ZFaklXc1hYbXNHdVU4Q1BRRFBTR0FNPQ==;MjIzODcxMkAzMjMxMmUzMDJlMzBLbTJnaTZKbjZnRXlwZmVTdzg1b1VhdXdjcFRwSlZBNzN0S1EyWStZVXNNPQ==;NRAiBiAaIQQuGjN/V0d+Xk9HfVldX2tWfFN0RnNYfVRxd19CZUwxOX1dQl9gSXtRf0RhWHhccHVUR2M=;MjIzODcxNEAzMjMxMmUzMDJlMzBmenN0UlJSaWJpTTA4Z21DWDZvWVp6MU9aN0Y1cHpUa3JnSzU0WnptTTNVPQ==;MjIzODcxNUAzMjMxMmUzMDJlMzBaUTNFNXZ4K25PRU1nSEdxeDY2d044ZTlWL2VIYklLUGNmeEQyZTh5QnlVPQ==;Mgo+DSMBMAY9C3t2VFhiQlJPcEBAVXxLflF1VWJbdV9zflFDcDwsT3RfQF5jTHxad0diXn1ecXNSRQ==;MjIzODcxN0AzMjMxMmUzMDJlMzBHRlZOWU5wdFl6WWcwVmcrMHlhd3JqUC91VkNEeHNuSVpKUHc3QjRja0FjPQ==;MjIzODcxOEAzMjMxMmUzMDJlMzBjSVNuNnYvLy9qZFJFeC9LNUpFYjk4TlRHNis5Z3FMVmhLSDJFQzY4QktRPQ==;MjIzODcxOUAzMjMxMmUzMDJlMzBmenN0UlJSaWJpTTA4Z21DWDZvWVp6MU9aN0Y1cHpUa3JnSzU0WnptTTNVPQ==");
		InitializeComponent();

		MainPage = new AppShell();
	}

}
