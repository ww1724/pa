using PA.ViewModels;
using ReactiveUI;
using System.Windows.Controls;

namespace PA.Views
{
    public class TestingViewViewBase : ReactiveUserControl<TestingViewModel> { }

    public partial class TestingView : TestingViewViewBase
    {
        public TestingView()
        {
            InitializeComponent();
        }
    }
}
