using PA.ViewModels;
using ReactiveUI;

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
        }
    }
}
