namespace theme;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnDark(object sender, EventArgs e)
	{
        Application.Current.UserAppTheme = AppTheme.Dark;
    }

    private void OnLight(object sender, EventArgs e)
    {
        Application.Current.UserAppTheme = AppTheme.Light;
    }

    private void OnNavigateToSecond(object sender, EventArgs e)
    {
        Navigation.PushAsync( new SecondPage() );
    }
}

