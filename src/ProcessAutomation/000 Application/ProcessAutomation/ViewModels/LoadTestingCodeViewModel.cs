using PA.Share.Mvvm;
using ReactiveUI;

namespace PA.ViewModels
{
    public class LoadTestingCodeViewModel : ReactiveObject, IViewModel, IRoutableViewModel
    {
        public string UrlPathSegment { get; }

        public IScreen HostScreen { get; set; }
    }
}
