namespace practice;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        var NavPage = new NavigationPage(new MainPage());
		NavPage.BarBackground = Colors.CornflowerBlue;
		NavPage.BarTextColor = Colors.White;
		MainPage = new Flyout();
    }
}
