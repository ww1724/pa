using PA.Share.Mvvm;
using PA.Share.Stores;
using PA.Views;
using ReactiveUI;
using Splat;
using System;
using System.Reactive;
using System.Reactive.Linq;

namespace PA.ViewModels
{
    public class ShellViewModel : ReactiveObject, IViewModel, IScreen
    {
        public RoutingState Router { get; }

        //public RouterStore RouterStore 
        //    => Locator.Current.GetService<RouterStore>();

        public ReactiveCommand<Unit, IRoutableViewModel> GoNext { get; }

        public ReactiveCommand<Unit, Unit> GoBack { get; }

        public ReactiveCommand<string, Unit> NavigationTo { get; }

        public ShellViewModel()
        {
            Router = new RoutingState();
            Locator.CurrentMutable.Register(() => new TestingView(), typeof(IViewFor<TestingViewModel>));

            Router.Navigate.Execute(new TestingViewModel());
            //GoNext = ReactiveCommand.CreateFromObservable(() => Router.Navigate.Execute(new TestingViewModel(this)));
            NavigationTo = ReactiveCommand.Create<string>(x => NavigateTo(x));
            //var canGoBack = this
            //    .WhenAnyValue(x => x.Router.NavigationStack.Count)
            //    .Select(count => count > 0);
            //GoBack = ReactiveCommand.CreateFromObservable(
            //        () => Router.NavigateBack.Execute(Unit.Default, Unit.Default),
            //        canGoBack);
        }

        public void NavigateTo(string path)
        {
            var a = (IRoutableViewModel)Locator.Current.GetService<IViewModel>(path);
            Router.Navigate.Execute(a);
        }


    }
}
