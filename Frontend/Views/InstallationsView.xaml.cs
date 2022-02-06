﻿using BetterMC.Core.Installations;
using BetterMC.Core.Installations.Management;
using BetterMC.Theme.Installations;
using System.Collections.Generic;
using System.Windows.Controls;

namespace BetterMC.Frontend.Views
{
    /// <summary>
    /// Логика взаимодействия для InstallationsView.xaml
    /// </summary>
    public partial class InstallationsView : UserControl
    {
        public InstallationsView()
        {
            InitializeComponent();
            InitVersions();
        }

        private void InitVersions()
        {
            InstallationsLoader loader = new InstallationsLoader();
            string mc = loader.FindMinecraft();
            string[] versions = loader.GetVersionPaths(ref mc);
            List<Installation> version = loader.LoadInstallations(versions);
            int index = installations_panel.Children.Count - 1;
            installations_panel.Children.Insert(index, new InstallationControl());
        }
    }
}
