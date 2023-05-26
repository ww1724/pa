using PA.Common.Model;
using PA.Share;
using PA.Share.Mvvm;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using Zoranof.WorkFlow;

namespace ProcessAutomation.ViewModels
{
    public class TestingItemEditorViewModel : ReactiveObject, IRoutableViewModel, IViewModel
    {
        public string UrlPathSegment => Constants.TestingItemEditorView;
        public IScreen HostScreen { get; }

        public string CurrentId { get; set; }

        public List<TestingItem> TestingItems { get; set; }

        public ObservableCollection<WorkflowNode> Nodes { get; set; }

        [Reactive]
        public string NewItemName { get; set; }

        private readonly Interaction<string, bool> confirm;
        public Interaction<string, bool> Confirm => this.confirm;

        public TestingItemEditorViewModel()
        {
            SaveTestingItemCommand = ReactiveCommand.Create(SaveTestingItemAction);

            this.confirm = new Interaction<string, bool>();
        }

        public ReactiveCommand<Unit, Unit> SaveTestingItemCommand { get; set; }

        public ReactiveCommand<Unit, Unit> NewTestingItemCommand { get; set; }

        public void SaveTestingItemAction()
        {

        }

        public void NewTestingItemAction()
        {

        }

    }
}
