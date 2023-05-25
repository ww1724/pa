using PA.Share;
using PA.Share.Mvvm;
using PA.Share.Stores;
using ReactiveUI;
using Splat;

namespace PA.ViewModels
{
    public class ConsoleViewModel : ReactiveObject, IRoutableViewModel, IViewModel
    {
        public string UrlPathSegment => Constants.ConsoleView;

        public IScreen HostScreen { get; set; }

        public RouterStore RouterStore
            => Locator.Current.GetService<RouterStore>();

        public ConsoleViewModel()
        {

        }
    }
}
