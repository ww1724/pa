using PA.Share.Mvvm;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Collections.ObjectModel;
using System.Reactive;
using Zoranof.Workflow.Base;
using Zoranof.WorkFlow;

namespace PA.Share.Stores
{
    public class TestingStore : ReactiveObject, IViewModel
    {

        [Reactive]
        public string WorkflowCode { get; set; }

        [Reactive]
        public string FlowChartCode { get; set; }

        private ObservableCollection<WorkflowNode> nodes;

        //[Reactive]
        public ObservableCollection<WorkflowNode> Nodes { get => nodes; set => this.RaiseAndSetIfChanged(ref nodes, value); }


        #region Commands
        public ReactiveCommand<Unit, Unit> AddRandomeNodeCommand { get; }

        #endregion

        public TestingStore() {
        }

        public string CurrentCode { get; set; }

        #region Actions
        #endregion


    }
}
