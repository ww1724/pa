using PA.ViewModels;
using ReactiveUI;
using System.Reactive.Disposables;

namespace PA.Views
{
    public class ConsoleViewBase : ReactiveUserControl<ConsoleViewModel> { }
    /// <summary>
    /// ConsoleView.xaml 的交互逻辑
    /// </summary>
    public partial class ConsoleView : ConsoleViewBase
    {
        public ConsoleView()
        {
            InitializeComponent();

            this.WhenActivated(
                d=>
                {
                    this.BindCommand(ViewModel, vm => vm.RouterStore.NavigationToCommand, v => v.TestingItemManage).DisposeWith(d);
                    this.BindCommand(ViewModel, vm => vm.RouterStore.NavigationToCommand, v => v.DeviceManage).DisposeWith(d);
                    this.BindCommand(ViewModel, vm => vm.RouterStore.NavigationToCommand, v => v.StatisticsManage).DisposeWith(d);
                    this.BindCommand(ViewModel, vm => vm.RouterStore.NavigationToCommand, v => v.DatabaseManage).DisposeWith(d);
                });
        }


    }
}
