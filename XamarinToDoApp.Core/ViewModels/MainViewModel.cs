using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using XamarinToDoApp.Core.Models;

namespace XamarinToDoApp.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        MvxObservableCollection<ListItem> items;

        public MvxObservableCollection<ListItem> Items
        {
            get { return items; }
            set { items = value; RaisePropertyChanged(() => Items); }
        }

        public MainViewModel()
        {
            Items = new MvxObservableCollection<ListItem> { new ListItem { Text = "123" }, new ListItem { Text = "1233" } };
        }

        //public ICommand GoCommand
        //{
        //    get
        //    {
        //        return new MvxCommand(() => ShowViewModel<TaskListViewModel>());
        //    }
        //}

        



    }
}
