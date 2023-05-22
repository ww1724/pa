using PA.Share;
using PA.Share.Mvvm;
using ReactiveUI;

namespace PA.ViewModels
{
    public class ConsoleViewModel : ReactiveObject, IRoutableViewModel, IViewModel
    {
        public ConsoleViewModel()
        {

        }

        public string UrlPathSegment => Constants.ConsoleView;

        public IScreen HostScreen { get; set;}
    }
}
