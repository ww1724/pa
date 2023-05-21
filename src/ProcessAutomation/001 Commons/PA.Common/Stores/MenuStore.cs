﻿using PA.Common.Model;
using PA.Common.Mvvm;
using ReactiveUI;
using System.Collections.ObjectModel;

namespace PA.Common.Stores
{


    public class MenuStore : ReactiveObject, IViewModel
    {
        private ObservableCollection<MenuItem>  appMenus;
        private MenuItem                        currentMenuItem;

        public ObservableCollection<MenuItem>   AppMenus { get => appMenus; set => this.RaiseAndSetIfChanged(ref appMenus, value); }

        public MenuItem                         CurrentMenuItem { get => currentMenuItem; set => this.RaiseAndSetIfChanged(ref currentMenuItem, value);  }


        public MenuStore()
        {
            AppMenus = new() {
                new MenuItem { Text="Testing Board", Path=Constants.TestingBoardView, CanClose=false },
                new MenuItem { Text="Console", Path=Constants.ConsoleView }
            };

            CurrentMenuItem = AppMenus[0];
        }
    }
}
