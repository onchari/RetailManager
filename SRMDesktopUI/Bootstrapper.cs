﻿using Caliburn.Micro;
using SRMDesktopUI.ViewModels;
using System.Windows;

namespace SRMDesktopUI
{
    class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();

        }
    }
}
