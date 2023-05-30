using Prism.Mvvm;

namespace NuevoGym.ViewModels
{
	public class MainWindowViewModel : BindableBase
	{
		private string _title = "GymCheck Wpf";
		public string Title
		{
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}

		public MainWindowViewModel()
		{

		}
	}
}
