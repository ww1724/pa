using PA.ViewModels;
using ReactiveUI;
using System.Reactive.Disposables;
using System.Windows;

namespace PA.Views
{
    public class WindowBase : ReactiveWindow<ShellViewModel> { }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ShellView : WindowBase
    {

        public ShellView()
        {
            InitializeComponent();
            ViewModel = new ShellViewModel();
            this.WhenActivated(o =>
            {
                this.OneWayBind(ViewModel, x => x.Router, x => x.ShellRouteHost.Router).DisposeWith(o);

            });
        }

        private void MinimizeWindow_Click(object sender, RoutedEventArgs e)
        {
           WindowState = WindowState.Minimized;
        }

        private void MaximizeWindow_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
