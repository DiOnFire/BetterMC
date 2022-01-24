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
         * Executes when we click close button
         * Closes launcher window
         */
        private void OnCloseClick(object sender, System.Windows.RoutedEventArgs e)
        {
            Close();
        }

        /*
         * Executes when we click minimize button
         * Minimizes launcher window
         */ 
        private void OnMinimizeButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }
    }
}