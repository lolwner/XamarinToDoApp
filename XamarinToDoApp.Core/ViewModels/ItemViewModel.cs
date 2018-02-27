using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinToDoApp.Core.Models;

namespace XamarinToDoApp.Core.ViewModels
{
    public class ItemViewModel : MvxViewModel
    {
        ListItem item;

        public ListItem Item
        {
            get { return item; }
            set { item = value; RaisePropertyChanged(() => Item); }
        }

        public ItemViewModel(ListItem _item)
        {
            Item = _item;
        }
    }
}
