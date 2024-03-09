using KnuckleBonesUI.ViewModel;

namespace KnuckleBonesUI;

public partial class GameUI : ContentPage
{
	public GameUI(GameViewModel gamevm)
	{
		InitializeComponent();
		BindingContext = gamevm;
	}
}