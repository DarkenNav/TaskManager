using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Logic.Models.Tasks
{
    public class TaskDTO
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public int? ContactorId { get; set; }
        public string Description { get; set; }

    }
}
