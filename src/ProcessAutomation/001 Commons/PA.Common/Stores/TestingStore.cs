using PA.Share.Mvvm;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Collections.ObjectModel;
using System.Reactive;
using Zoranof.Workflow;
using Zoranof.Workflow.Base;
using Zoranof.WorkFlow;

namespace PA.Share.Stores
{
    public class TestingRecord
    {

    }

    public class TestingStore : ReactiveObject, IViewModel
    {

        [Reactive]
        public string WorkflowCode { get; set; }

        [Reactive]
        public string FlowChartCode { get; set; }

        [Reactive]
        public string CurrentCode { get; set; }

        private ObservableCollection<WorkflowNode> nodes;
        private ObservableCollection<TestingRecord> testingRecords;

        public ObservableCollection<WorkflowNode> Nodes { get => nodes; set => this.RaiseAndSetIfChanged(ref nodes, value); }

        public ObservableCollection<TestingRecord> TestingRecords { get => testingRecords; set => this.RaiseAndSetIfChanged(ref testingRecords, value); }

        public TestingDynamicData Storage { get; set; }



        #region Commands
        public ReactiveCommand<Unit, Unit> AddRandomeNodeCommand { get; }

        #endregion

        public TestingStore() {

            AddRandomeNodeCommand = ReactiveCommand.Create(() => AddRandomeNode());
            
        }

        

        #region Actions
        public void AddRandomeNode()
        {

        }
        #endregion


    }
}
