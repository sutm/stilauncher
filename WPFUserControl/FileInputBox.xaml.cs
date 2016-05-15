using Microsoft.Win32;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            OpenFileDialog d = new OpenFileDialog();
            if (d.ShowDialog() == true)
                this.FileName = d.FileName;
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
