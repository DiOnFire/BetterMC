using BetterMC.Frontend.ViewModel;
using static System.Windows.Application;

namespace BetterMC.Frontend.Util
{
    public static class Utils
    {
        public static MainViewModel GetMainViewModel()
        {
            return (MainViewModel) GetMainWindow()?.DataContext;
        }

        public static MainWindow GetMainWindow()
        {
            return Current.MainWindow as MainWindow;
        }

        public static object GetCurrentViewModel()
        {
            return GetMainViewModel().CurrentView;
        }

        public static void SetViewModel(object newViewModel)
        {
            GetMainViewModel().CurrentView = newViewModel;
        }
    }
}
