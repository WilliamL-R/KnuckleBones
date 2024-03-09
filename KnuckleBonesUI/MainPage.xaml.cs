namespace KnuckleBonesUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private async void OnNavigationClicked(object sender, EventArgs e)
	{
		// Name is gathered from the Routing in AppShell.xaml.cs
		await Shell.Current.GoToAsync("GameUI");
	}
}

