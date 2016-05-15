using System.Windows;
using System.Windows.Controls;

namespace WPFUserControl
{
    /// <summary>
    /// Interaction logic for FolderInputBox.xaml
    /// </summary>
    public partial class FolderInputBox : UserControl
    {
        public FolderInputBox()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty FolderNameProperty =
            DependencyProperty.Register("FolderName", typeof(string), typeof(FolderInputBox));

        public string FolderName
        {
            get { return (string)GetValue(FolderNameProperty); }
            set { SetValue(FolderNameProperty, value); }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new System.Windows.Forms.FolderBrowserDialog();
            dlg.SelectedPath = this.FolderName;

            Window parent = Window.GetWindow(this);
            var result = dlg.ShowDialog(WpfExtensions.GetIWin32Window(parent));

            if (result == System.Windows.Forms.DialogResult.OK)
                this.FolderName = dlg.SelectedPath;
        }

        public static readonly RoutedEvent FolderNameChangedEvent =
            EventManager.RegisterRoutedEvent(
                "FolderNameChanged",
                RoutingStrategy.Bubble,
                typeof(RoutedEventHandler),
                typeof(FolderInputBox));

        public event RoutedEventHandler FolderNameChanged
        {
            add { AddHandler(FolderNameChangedEvent, value); }
            remove { RemoveHandler(FolderNameChangedEvent, value); }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.Handled = true;
            RoutedEventArgs args = new RoutedEventArgs(FolderNameChangedEvent);
            RaiseEvent(args);
        }
    }
}
