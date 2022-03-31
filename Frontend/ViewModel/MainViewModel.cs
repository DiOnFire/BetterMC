using BetterMC.Core;
using BetterMC.Frontend.Executor;
using static System.Windows.Application;

namespace BetterMC.Frontend.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand BloomwareViewCommand;
        public RelayCommand DashboardViewCommand;
        public RelayCommand AltsViewCommand;
        public RelayCommand InstallationsViewCommand;
        public RelayCommand SettingsViewCommand;
        public RelayCommand NewAccountCommand;

        public DashboardViewModel DashboardView;
        public BloomwareViewModel BloomwareView;
        public SettingsViewModel SettingsView;
        public InstallationsViewModel InstallationsView;
        public AltsViewModel AltsView;
        public NewAccountViewModel NewAccountView;

        private object currentView;

        public object CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                OnPropertyChanged();
                if ((Current.MainWindow.DataContext as MainViewModel) != null) SwitchViewModelExecutor.SwitchViewModel();
            }
        }

        public MainViewModel()
        {
            DashboardView = new DashboardViewModel();
            BloomwareView = new BloomwareViewModel();
            SettingsView = new SettingsViewModel();
            InstallationsView = new InstallationsViewModel();
            AltsView = new AltsViewModel();
            NewAccountView = new NewAccountViewModel();

            CurrentView = DashboardView;
            
            DashboardViewCommand = new RelayCommand(o => CurrentView = DashboardView);
            BloomwareViewCommand = new RelayCommand(o => CurrentView = BloomwareView);
            AltsViewCommand = new RelayCommand(o => CurrentView = AltsView);
            InstallationsViewCommand = new RelayCommand(o => CurrentView = InstallationsView);
            SettingsViewCommand = new RelayCommand(o => CurrentView = SettingsView);
            NewAccountCommand = new RelayCommand(o => CurrentView = NewAccountView);
        }
    }
}
