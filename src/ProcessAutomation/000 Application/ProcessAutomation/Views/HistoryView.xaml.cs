using PA.ViewModels;
using ReactiveUI;
using System.Windows.Controls;

namespace PA.Views
{

    public class HistoryViewBase : ReactiveUserControl<HistoryViewModel> { }
    /// <summary>
    /// HistoryView.xaml 的交互逻辑
    /// </summary>
    public partial class HistoryView : HistoryViewBase
    {
        public HistoryView()
        {
            InitializeComponent();
        }
    }
}
