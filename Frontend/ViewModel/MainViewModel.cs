using BetterMC.Core;

namespace BetterMC.Frontend.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand BloomwareViewCommand
        {
            get; set;
        }

        public RelayCommand DashboardViewCommand
        {
            get; set;
        }

        public DashboardViewModel DashboardView
        {
            get; set;
        }

        public BloomwareViewModel BloomwareView
        {
            get; set;
        }

        private object currentView;

        public object CurrentView
        {
            get
            {
                return currentView;
            }
            set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            DashboardView = new DashboardViewModel();
            BloomwareView = new BloomwareViewModel();
            CurrentView = DashboardView;
            
            DashboardViewCommand = new RelayCommand(o =>
            {
                CurrentView = DashboardView;
            });
            BloomwareViewCommand = new RelayCommand(o =>
            {
                CurrentView = BloomwareView;
            });
        }
    }
}
