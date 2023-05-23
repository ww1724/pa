using PA.ViewModels;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive.Disposables;
using Zoranof.Workflow;
using Zoranof.WorkFlow;

namespace PA.Views
{
    public class TestingViewBase : ReactiveUserControl<TestingViewModel> { }

    public partial class TestingView : TestingViewBase
    {
        public TestingView()
        {
            InitializeComponent();



            this.WhenActivated(
                d =>
                {
                    this.Bind(ViewModel, vm => vm.TestingStore.Nodes, v => v.WorkflowEditor.Items).DisposeWith(d);

                    //this.BindCommand(ViewModel, vm => vm.TestingStore.AddRandomeNodeCommand, v => v.AddRandomNode).DisposeWith(d);
                });
        }
    }
}
