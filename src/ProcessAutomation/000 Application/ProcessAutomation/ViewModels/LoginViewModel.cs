using PA.Share.Mvvm;
using ReactiveUI;

namespace PA.ViewModels
{
    public class LoginViewModel : ReactiveObject, IViewModel, IRoutableViewModel
    {
        public string UrlPathSegment {get; set;}

        public IScreen HostScreen { get; set;}
    }
}
