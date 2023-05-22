using PA.Share;
using PA.Share.Mvvm;
using ReactiveUI;

namespace PA.ViewModels
{
    public class EditorViewModel : ReactiveObject, IViewModel, IRoutableViewModel
    {
        public string UrlPathSegment => Constants.EditorView;

        public IScreen HostScreen { get; }
    }
}
