using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fligern.UsefulReminder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The child window
        /// </summary>
        private Window _childWindow;

        public Window ChildWindow
        {
            get { return _childWindow; }
            set
            {
                _childWindow = value;               

            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (_childWindow != null)
            {
                var viewModel = this.DataContext as MainViewModel;
                viewModel.FetchRandomData();
                _childWindow.ShowDialog();
            }
        }
    }
}
