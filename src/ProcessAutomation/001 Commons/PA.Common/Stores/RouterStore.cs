using PA.Share.Model;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.Share.Stores
{
    public class RouterStore : ReactiveObject
    {
        public RouterStore()
        {

        }

        //ReactiveCommand ShellNavigationTo

        //private ObservableCollection<MenuItem> appMenus;
        //private MenuItem currentMenuItem;

        //public ObservableCollection<MenuItem> AppMenus { get => appMenus; set => this.RaiseAndSetIfChanged(ref appMenus, value); }

        //public MenuItem CurrentMenuItem { get => currentMenuItem; set => this.RaiseAndSetIfChanged(ref currentMenuItem, value); }


        //public MenuStore()
        //{
        //    AppMenus = new() {
        //        new MenuItem { Text="Testing Board", Path=Constants.TestingBoardView, CanClose=false },
        //        new MenuItem { Text="Console", Path=Constants.ConsoleView }
        //    };

        //    CurrentMenuItem = AppMenus[0];
        //}
    }
}
