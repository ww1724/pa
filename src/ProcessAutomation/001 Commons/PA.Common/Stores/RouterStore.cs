using PA.Share.Model;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace PA.Share.Stores
{
    public class RouterStore : ReactiveObject
    {
        public RouterStore()
        {
            NavigationToCommand = ReactiveCommand.Create<string>(path =>
            {
                MessageBus.Current.SendMessage(path, "NavigationTo");
            });
        }

        public ReactiveCommand<string, Unit> NavigationToCommand { get; set; }
    }
}
