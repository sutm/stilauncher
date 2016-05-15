using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;

namespace WPFUserControl
{
    /// <summary>
    /// Interaction logic for FileInputBox.xaml
    /// </summary>
    public partial class FileInputBox : UserControl
    {
        public FileInputBox()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty FileNameProperty =
            DependencyProperty.Register("FileName", typeof(string), typeof(FileInputBox));

        public string FileName
        {
            //get { return textBox.Text; }
            //set { textBox.Text = value; }
            get { return (string)GetValue(FileNameProperty); }
            set { SetValue(FileNameProperty, value); }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = this.FileName;
            if (dlg.ShowDialog() == true)
                this.FileName = dlg.FileName;
        }

        public static readonly RoutedEvent FileNameChangedEvent =
            EventManager.RegisterRoutedEvent(
                "FileNameChanged",
                RoutingStrategy.Bubble,
                typeof(RoutedEventHandler),
                typeof(FileInputBox));

        //public event EventHandler<EventArgs> FileNameChanged;
        public event RoutedEventHandler FileNameChanged
        {
            add { AddHandler(FileNameChangedEvent, value); }
            remove { RemoveHandler(FileNameChangedEvent, value); }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.Handled = true;
            //if (FileNameChanged != null)
            //    FileNameChanged(this, EventArgs.Empty);
            RoutedEventArgs args = new RoutedEventArgs(FileNameChangedEvent);
            RaiseEvent(args);
        }

    }
}
