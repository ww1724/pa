
using PA.Share.Mvvm;
using ReactiveUI;

namespace PA.ViewModels
{
    public class NewTabViewModel : ReactiveObject, IViewModel, IRoutableViewModel
    {
        public NewTabViewModel()
        {
            
        }

        public string UrlPathSegment {get; set;}

        public IScreen HostScreen { get; set; }
    }
}
