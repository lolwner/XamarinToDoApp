using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinToDoApp.Core.Interfaces;
using XamarinToDoApp.Core.Models;

namespace XamarinToDoApp.Core.Services
{
    public class TaskService : ITaskService
    {
        public void AddTask(TaskItem task)
        {

        }

        public void DeleteTask(TaskItem task)
        {

        }

        public List<TaskItem> GetAllTasks()
        {
            List<TaskItem> tmpList = new List<TaskItem>();
            tmpList.Add( new TaskItem { Description = "Descr", Id = "0", Status = 0, Title = "Title1" });
            tmpList.Add(new TaskItem { Description = "Descr2", Id = "1", Status = 1, Title = "Title2" });
            tmpList.Add(new TaskItem { Description = "Descr3", Id = "2", Status = 0, Title = "Title3" });
            return tmpList;
        }
    }
}
