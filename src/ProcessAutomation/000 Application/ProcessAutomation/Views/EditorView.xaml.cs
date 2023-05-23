using PA.ViewModels;
using ReactiveUI;
using System;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using Zoranof.Workflow.Common;

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
                    this.Bind(ViewModel, vm => vm.TestingStore.Nodes, v => v.CodeEditor.Items).DisposeWith(d);
                    this.OneWayBind(ViewModel, vm => vm.NodeItemMetas, v => v.NodeSelectTree.ItemsSource).DisposeWith(d);
                });
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
        }

        private void NodeSelectTree_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
            {
                if (e.Source != null) 
                {
                    var view = sender as ListView;
                    if (view.SelectedItem == null) return;
                    DataObject data = new DataObject(DataTypeExtension.DragDataModelFormat, (view.SelectedItem as NodeItemMeta).Type);
                    DragDrop.DoDragDrop(view, data, DragDropEffects.Move);
                }
            }
        }
    }
}
