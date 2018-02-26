using System;
using System.Collections.Generic;
using System.Text;
using XamarinToDoApp.Core.Models;

namespace XamarinToDoApp.Core.Interfaces
{
    public interface ITaskService
    {
        void AddNewTask(TaskItem task);
        void DeleteTask(TaskItem task);
        void ChangeStatus(TaskItem task);
    }
}
