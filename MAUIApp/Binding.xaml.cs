using MAUIApp.ViewModels;

namespace MAUIApp;

public partial class Binding : ContentPage
{
	BindingViewModel _vm;

	public Binding()
	{
		InitializeComponent();

		BindingContext = _vm = new BindingViewModel()
		{
			Name = "John",
			Phone = "9999",
			Address = "X Address"
		};
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		_vm.Name = "Peter";
		_vm.Phone = "0000";
		_vm.Address = "New Address";
	}
}