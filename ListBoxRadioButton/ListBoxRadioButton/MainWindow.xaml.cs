using System;

using System.Windows;
using ListBoxRadioButton.ViewModels;


namespace ListBoxRadioButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            ((MainViewModel)DataContext).SaveSetting();
        }
    }
}
