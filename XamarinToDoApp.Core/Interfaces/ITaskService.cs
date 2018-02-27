using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinToDoApp.Core.Models;

namespace XamarinToDoApp.Core.Interfaces
{
    public interface ITaskService
    {
        void AddTask(TaskItem task);
        void DeleteTask(TaskItem task);
        List<TaskItem> GetAllTasks();
    }
}
