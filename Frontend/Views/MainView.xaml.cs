using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using BetterMC.Frontend.ViewModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BetterMC.Frontend.Views
{
    /// <summary>
    /// Логика взаимодействия для MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        /*
         * Executes when you click the GitHub border.
         * Opens repository link in default browser.
         */ 
        private void OnGitHubBorderClick(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DiOnFire/BetterMC");
        }

        private void OnBloomwareButtonMouseClick(object sender, MouseButtonEventArgs e)
        {
            new MainViewModel().CurrentView = new MainViewModel().BloomwareView;
        }
    }
}
