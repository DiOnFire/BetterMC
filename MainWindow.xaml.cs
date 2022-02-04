using BetterMC.Frontend.Executor;

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
        private void OnCloseClick(object sender, System.Windows.RoutedEventArgs e)
        {
            Close();
        }

        /*
         * Executes when you click minimize button
         * Minimizes launcher window
         */ 
        private void OnMinimizeButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        /*
         * Executes when you click launch button
         * Launchs Minecraft (using selected version)
         */ 
        private void OnLaunchButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            new SwitchViewModelExecutor().SwitchViewModel();
        }

        /*
         * Executes when you start dragging the window on upper stack panel (id: upper_stackpanel) 
         * Drags launcher window
         */ 
        private void OnMouseDownUpperStackPanel(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == System.Windows.Input.MouseButton.Left) this.DragMove();
        }

        /*
         * Executes when you click "new alt" button
         * Opens "new alt" window
         */ 
        private void OnNewAltButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        /*
         * Executes when you click "configure installation" button 
         * Opens "installation's settings" window
         */
        private void OnConfigButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}