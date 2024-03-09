using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace KnuckleBonesUI.ViewModel
{
	public partial class GameViewModel : ObservableObject
	{
		public GameViewModel()
		{
			PlayerGrid = new int[2, 2];
		}

		[ObservableProperty]
		int rolledNumber;

		[ObservableProperty]
		int[,] playerGrid;

		[RelayCommand]
		void Roll()
		{
			RolledNumber = 0;
			var random = new Random();
			var rolledDice = random.Next(1, 7);
			RolledNumber = rolledDice;
		}
	}
}
