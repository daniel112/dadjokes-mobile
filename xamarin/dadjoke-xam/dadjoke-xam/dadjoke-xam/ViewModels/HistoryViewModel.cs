using System;

namespace dadjoke_xam.ViewModels
{
	public class HistoryViewModel : BaseViewModel
	{
		public string[] Items { get; set; }
		public HistoryViewModel()
		{
			Title = "History";
		}
	}
}

