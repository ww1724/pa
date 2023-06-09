﻿using PA.Share;
using PA.Share.Mvvm;
using PA.Share.Stores;
using ReactiveUI;
using Splat;

namespace PA.ViewModels
{
    public class TestingViewModel : ReactiveObject, IRoutableViewModel, IViewModel
    {
        public TestingStore TestingStore
            => Locator.Current.GetService<TestingStore>();

        public string UrlPathSegment => Constants.TestingView;

        public IScreen HostScreen { get; }

        public TestingViewModel()
        {
        }
    }

    //    #region Props


    //    IServiceProvider serviceProvider
    //        => Locator.Current.GetService<IServiceProvider>();

    //    IWorkflowHost Host;
    //    private string text;

    //    public string Text { get => text; set => this.RaiseAndSetIfChanged(ref text, value); }

    //    private ObservableCollection<WorkflowNode> items;

    //    public ObservableCollection<WorkflowNode> Items { get => items; set => this.RaiseAndSetIfChanged(ref  items, value); }


    //    #endregion


    //    #region Actions
    //    public void AddSomeThingToGraphicsView()
    //    {
    //        Items.Add(new WorkflowNode { Pos = new Point((new Random().Next(0, 500)), (new Random().Next(0, 500))) });
    //    }

    //    public async void Test1Action()
    //    {
    //        Host.RegisterWorkflow<HWorkflow, MyData>();
    //        await Task.Run(() =>
    //        {
    //            Host.Start();
    //        });
    //        var id = await Host.StartWorkflow<MyData>("H", 1, new MyData { A = 100, B = 10 });
    //    }

    //    public void Test2Action() { }

    //    public void Test3Action() { }

    //    public void Test4Action() { }

    //    #endregion



    //}

    //public class MyData
    //{
    //    public int A;

    //    public int B;

    //    public int Result;
    //}

    //public class HWorkflow : IWorkflow<MyData>
    //{
    //    public string Id => "H";

    //    public int Version => 1;

    //    public void Build(IWorkflowBuilder<MyData> builder)
    //    {
    //    }
    //}
}
