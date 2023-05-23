using PA.ViewModels;
using ReactiveUI;
using System;

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


            this.WhenActivated(
                d =>
                {
                    //this.Bind(ViewModel, vm => vm.NodeItemMetas, v => v.NodeSelectTree.Items).DisposeWith(d);
                });
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
        }
    }
}
