using BetterMC.Frontend.Executor;
using BetterMC.Frontend.Util;
using System.Windows;
using System.Windows.Input;

namespace BetterMC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /*
         * Executes when you click close button
         * Closes launcher window
         */
        private void OnCloseClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /*
         * Executes when you click minimize button
         * Minimizes launcher window
         */ 
        private void OnMinimizeButtonClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        /*
         * Executes when you click launch button
         * Launchs Minecraft (using selected version)
         */ 
        private void OnLaunchButtonClick(object sender, RoutedEventArgs e)
        {
            SwitchViewModelExecutor.Execute();
        }

        /*
         * Executes when you start dragging the window on upper stack panel (id: upper_stackpanel) 
         * Drags launcher window
         */ 
        private void OnMouseDownUpperStackPanel(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) this.DragMove();
        }

        /*
         * Executes when you click "new alt" button
         * Opens "new alt" window
         */ 
        private void OnNewAltButtonClick(object sender, RoutedEventArgs e)
        {
            SwitchViewModelExecutor.NewAltButtonClick();
        }

        /*
         * Executes when you click "configure installation" button 
         * Opens "installation's settings" window
         */
        private void OnConfigButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void OnMainButtonClick(object sender, RoutedEventArgs e)
        {

        }

        /*
         * Executes when you press some key on keyboard
         * 
         */
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                switch (Utils.GetCurrentViewModel().GetType().Name)
                {
                    case "NewAccountViewModel":
                        Utils.SetViewModel(Utils.GetMainViewModel().AltsView);
                        break;
                }
            }
        }
    }
}