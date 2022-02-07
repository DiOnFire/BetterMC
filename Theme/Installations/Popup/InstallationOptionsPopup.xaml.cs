using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BetterMC.Theme.Installations.Popup
{
    /// <summary>
    /// Логика взаимодействия для InstallationOptionsPopup.xaml
    /// </summary>
    public partial class InstallationOptionsPopup : UserControl
    {
        public InstallationOptionsPopup()
        {
            InitializeComponent();
        }

        private void main_control_MouseLeave(object sender, MouseEventArgs e)
        {
            options_popup.IsOpen = false;
        }
    }
}
