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
using MahApps.Metro.Controls;


namespace stilauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private Flyout downloadFlyout = new Flyout();

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new ViewModels.MainViewModel();
        }

        private void ShowDownload(object sender, RoutedEventArgs e)
        {
            this.downloadFlyout.IsOpen = !this.downloadFlyout.IsOpen;
        }

        private void EditConfig_Clicked(object sender, RoutedEventArgs e)
        {
            Button cmd = (Button)sender;
            if (cmd.DataContext is ViewModels.ConfigViewModel)
            {
                var item = (ViewModels.ConfigViewModel)cmd.DataContext;
                //ConfigList.Remove(item);
            }
        }
    }
}
