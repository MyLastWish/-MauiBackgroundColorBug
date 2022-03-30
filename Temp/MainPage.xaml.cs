namespace Temp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnToggleClicked(object sender, EventArgs e)
	{
		Application.Current.UserAppTheme = Application.Current.UserAppTheme is AppTheme.Dark ? AppTheme.Light : AppTheme.Dark ;
	}
}

