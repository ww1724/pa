using PA.ViewModels;
using ReactiveUI;

namespace PA.Views
{
    public class EditorViewBase : ReactiveUserControl<EditorViewModel> { }

    /// <summary>
    /// EditorView.xaml 的交互逻辑
    /// </summary>
    public partial class EditorView : EditorViewBase
    {
        public EditorView()
        {
            InitializeComponent();
        }
    }
}
