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
        public MainViewModel()
        {
           
        }

        public void ShowFragment()
        {
            ShowViewModel<ListFragmentViewModel>();
        }
    }
}
