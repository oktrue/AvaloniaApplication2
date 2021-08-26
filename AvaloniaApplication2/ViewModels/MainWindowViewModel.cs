using ReactiveUI;
using System.Diagnostics;
using System.Reactive;

namespace AvaloniaApplication2.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            LoginCommand = ReactiveCommand.Create(Login);
        }

        public ReactiveCommand<Unit, Unit> LoginCommand { get; }

        void Login()
        {
            Debug.WriteLine("Login");
        }
    }
}
