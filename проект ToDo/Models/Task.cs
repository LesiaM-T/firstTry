using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Task
    {
        public int taskId { get; set; }
        public string taskName { get; set; }
        public string taskText { get; set; }
        public int columnId { get; set; }
        public int userId { get; set; }
    }
}
