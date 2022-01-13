using System.Diagnostics;
using MvvmCross.Platforms.Wpf.Views;

namespace Pins.WPF.Views
{
    /// <summary>
    /// Interaction logic for StartupView.xaml
    /// </summary>
    public partial class StartupView : MvxWpfView
    {
        public StartupView()
        {
            InitializeComponent();
        }

        private void MvxWpfView_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            Debug.WriteLine("");
        }
    }
}
