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

		[RelayCommand]
		void AssignGrid(int columnSelected)
		{
			var row = GetNextRow(columnSelected);
			if (row == -1)
			{
				// Column is full.
				//TODO: Handle Alerting the player in seperate method.
				return;
			}
			PlayerGrid[row, columnSelected] = RolledNumber;
		}

		private int GetNextRow(int columnSelected)
		{
			for (int row = 0; row < PlayerGrid.GetLength(0); row++)
			{
				if (PlayerGrid[row, columnSelected] == 0)
				{
					return row;
				}
			}
			return -1;
		}
	}
}
