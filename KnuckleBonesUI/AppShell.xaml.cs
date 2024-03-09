namespace KnuckleBonesUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("GameUI", typeof(GameUI));
	}
}
