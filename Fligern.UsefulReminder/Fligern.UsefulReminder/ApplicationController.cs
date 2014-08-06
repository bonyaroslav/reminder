using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Fligern.UsefulReminder
{
    sealed class ApplicationController
    {
        MainViewModel viewModel;
        MainWindow window;
        Window ownedWindow;
        public void Initialize()
        {
            viewModel = new MainViewModel();            
           
            window= new MainWindow();
            window.DataContext = viewModel;

            Fligern.UsefulReminder.Controls.QuotePopup popup = new Controls.QuotePopup();
            popup.DataContext = viewModel;

            ownedWindow = new Window();
            //ownedWindow.Owner = window;
            ownedWindow.Content = popup;

            window.ChildWindow = ownedWindow;
            window.Show();

            
        }
    }
}
