using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinToDoApp.Core.Models;

namespace XamarinToDoApp.Core.ViewModels
{
    public class ListFragmentViewModel : MvxViewModel
    {

        MvxObservableCollection<ListItem> items;

        public MvxObservableCollection<ListItem> Items
        {
            get { return items; }
            set { items = value; RaisePropertyChanged(() => Items); }
        }
        public ListFragmentViewModel()
        {
            Items = new MvxObservableCollection<ListItem> { new ListItem { Text = "123", Description = "123des" }, new ListItem { Text = "1233", Description = "1233des" } };
        }

        public MvxCommand ItemClickCommand
        {
            get
            {
                return new MvxCommand(() =>
                {

                });
                //ShowViewModel<ListFragmentViewModel>()
                //);
            }
        }
    }
}
