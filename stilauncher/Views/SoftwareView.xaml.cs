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

namespace stilauncher.Views
{
    /// <summary>
    /// Interaction logic for SoftwareView.xaml
    /// </summary>
    public partial class SoftwareView : UserControl
    {
        public SoftwareView()
        {
            InitializeComponent();

            this.DataContext = new ViewModels.SoftwareViewModel();
        }

        private void ServerFolder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
