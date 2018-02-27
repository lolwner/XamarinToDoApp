using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using XamarinToDoApp.Core.Interfaces;
using XamarinToDoApp.Core.Models;

namespace XamarinToDoApp.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        readonly ITaskService _taskService;

        public MainViewModel(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public void ShowFragment()
        {
            ShowViewModel<ListFragmentViewModel>();
        }
    }
}
