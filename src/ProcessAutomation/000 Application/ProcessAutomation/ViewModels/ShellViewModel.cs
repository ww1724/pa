using PA.Share;
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
            NavigationTo = ReactiveCommand.Create<string>(x => NavigateToAction(x));
            MessageBus.Current.Listen<string>("NavigationTo").Subscribe(NavigateToAction);
        }

        public void NavigateToAction(string path)
        {
            var a = (IRoutableViewModel)Locator.Current.GetService<IViewModel>(path);
            this.Router.Navigate.Execute(a);
        }



    }
}
