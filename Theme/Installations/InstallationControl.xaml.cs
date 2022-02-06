using BetterMC.Core.Installations;
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

namespace BetterMC.Theme.Installations
{
    /// <summary>
    /// Логика взаимодействия для InstallationControl.xaml
    /// </summary>
    public partial class InstallationControl : UserControl
    {
        private Installation _installation;

        public InstallationControl(Installation installation)
        {
            InitializeComponent();
            this._installation = installation;
            InitComponent();
        }

        private void InitComponent()
        {
            installation_name.Text = _installation.name;
            installation_version.Text = _installation.type.ToString();
        }
    }
}
