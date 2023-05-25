using Microsoft.Extensions.DependencyInjection;
using PA.Common.Model;
using PA.Service;
using PA.Service.Interface;
using PA.Share.Mvvm;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Windows;
using WorkflowCore.Interface;
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

        public IDbService DbService 
            => Locator.Current.GetService<IDbService>();

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

        public TestingDynamicData TestingStorage { get; set; }

        public IWorkflowHost Host 
            => Locator.Current.GetService<IServiceProvider>().GetService<IWorkflowHost>();

        [Reactive]
        public ObservableCollection<TestingItem> TestingItems { get; set; }

        public TestingStore() {
            TestCommand = ReactiveCommand.Create(() => MainTestAction());
            TestingItems = new ObservableCollection<TestingItem>(
                DbService.Query<TestingItem>());

        }

        #region Commands
        public ReactiveCommand<Unit, Unit> TestCommand { get; set; }

        public ReactiveCommand<Unit, Unit> SaveWorkflowNodes { get; set; }
        #endregion

        #region Actions
        public void MainTestAction ()
        {
            MessageBox.Show("Testing Start");
        }
        #endregion

        public void SaveWorkflowNodesAction()
        {

        }

    }
}
