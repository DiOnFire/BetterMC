using BetterMC.Core;
using BetterMC.Frontend.Executor;
using static System.Windows.Application;

namespace BetterMC.Frontend.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand BloomwareViewCommand { get; set; }
        public RelayCommand DashboardViewCommand { get; set; }
        public RelayCommand AltsViewCommand { get; set; }
        public RelayCommand InstallationsViewCommand { get; set; }
        public RelayCommand SettingsViewCommand { get; set; }
        public RelayCommand NewAccountCommand { get; set; }

        public DashboardViewModel DashboardView { get; set; }
        public BloomwareViewModel BloomwareView { get; set; }
        public SettingsViewModel SettingsView { get; set; }
        public InstallationsViewModel InstallationsView { get; set; }
        public AltsViewModel AltsView { get; set; }
        public NewAccountViewModel NewAccountView { get; set; }

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
