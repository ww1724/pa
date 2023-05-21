using PA.ViewModels;
using ReactiveUI;

namespace PA.Views
{
    public class LoginViewBase : ReactiveUserControl<LoginViewModel> { }

    /// <summary>
    /// LoginView.xaml 的交互逻辑
    /// </summary>
    public partial class LoginView : LoginViewBase
    {
        public LoginView()
        {
            InitializeComponent();
        }
    }
}
