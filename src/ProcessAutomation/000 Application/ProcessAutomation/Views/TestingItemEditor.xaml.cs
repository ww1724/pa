using ProcessAutomation.ViewModels;
using ReactiveUI;
using System.Windows;
using System.Windows.Controls;
using Zoranof.Workflow.Common;

namespace PA.Views
{
    public class TestingItemEditorBase : ReactiveUserControl<TestingItemEditorViewModel> { }

    public partial class TestingItemEditor : TestingItemEditorBase
    {
        public TestingItemEditor()
        {
            InitializeComponent();
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
