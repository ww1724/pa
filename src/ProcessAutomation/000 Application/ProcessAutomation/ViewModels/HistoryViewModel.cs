
using PA.Share.Mvvm;
using ReactiveUI;

namespace PA.ViewModels
{
    public class HistoryViewModel : ReactiveObject, IViewModel, IRoutableViewModel
    {
        public HistoryViewModel()
        {
            
        }

        public string UrlPathSegment { get; }

        public IScreen HostScreen { get; }
    }
}
