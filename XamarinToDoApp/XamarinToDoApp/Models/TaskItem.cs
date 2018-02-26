using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinToDoApp.Core.Models
{
    public class TaskItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
    }
}
