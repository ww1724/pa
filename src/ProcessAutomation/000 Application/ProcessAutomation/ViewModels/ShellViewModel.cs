using PA.Common.Mvvm;
using PA.Views;
using ReactiveUI;
using Splat;
using System.Reactive;
using System.Reactive.Linq;

namespace PA.ViewModels
{
    public class ShellViewModel : ReactiveObject, IViewModel, IScreen
    {
        public RoutingState Router { get; }

        public ReactiveCommand<Unit, IRoutableViewModel> GoNext { get; }

        public ReactiveCommand<Unit, Unit> GoBack { get; }

        public ShellViewModel()
        {
            Router = new RoutingState();
            Locator.CurrentMutable.Register(() => new TestingView(), typeof(IViewFor<TestingViewModel>));

            Router.Navigate.Execute(new TestingViewModel(this));
            GoNext = ReactiveCommand.CreateFromObservable(() => Router.Navigate.Execute(new TestingViewModel(this)));

            //var canGoBack = this
            //    .WhenAnyValue(x => x.Router.NavigationStack.Count)
            //    .Select(count => count > 0);
            //        GoBack = ReactiveCommand.CreateFromObservable(
            //            () => Router.NavigateBack.Execute(Unit.Default),
            //            canGoBack);
        }



    }
}
