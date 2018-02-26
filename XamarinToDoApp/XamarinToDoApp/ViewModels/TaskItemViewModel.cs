using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinToDoApp.Core.Interfaces;
using XamarinToDoApp.Core.Models;

namespace XamarinToDoApp.Core.ViewModels
{
    class TaskItemViewModel : MvxViewModel
    {
        readonly ITaskService _itaskService;

        public TaskItemViewModel(ITaskService itaskService)
        {
            _itaskService = itaskService;
        }

        public override void Start()
        {
            Test();
            base.Start();
        }

        public TaskItem item = new TaskItem { Id = "1", Description = "Descr", Status = 0, Title = "Title" };

        void Test()
        {
            _itaskService.AddNewTask(item);
        }
    }
}
