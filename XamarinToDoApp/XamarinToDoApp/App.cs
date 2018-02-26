using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using XamarinToDoApp.Core.Interfaces;
using XamarinToDoApp.Core.Services;
using XamarinToDoApp.Core.ViewModels;

namespace XamarinToDoApp
{
    public class App : MvxApplication
    {
        public App() 
        {
            Mvx.RegisterType<ITaskService, TaskService>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TaskItemViewModel>());
        }
    }
}
