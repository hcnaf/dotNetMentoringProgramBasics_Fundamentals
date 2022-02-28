using System.Windows;
using HelloWorldLib;

namespace dotNetMentoringProgramBasics_Fundamentals_WPF
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

        private void SayHello_Click(object sender, RoutedEventArgs e) => MessageBox.Show(HelloWorldHelper.SayHello(NameTextBox.Text));
    }
}
