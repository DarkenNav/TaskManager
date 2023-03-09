using System;
using TaskManager.Logic.Models.Tasks;

namespace TaskManager.Logic
{
    public class TaskService
    {
        public TaskService() { }

        public TaskDTO Get(int id)
        {
            var task = new TaskDTO()
            {
                Id = id,
                Subject = "Новый мир",
                Description = "Мы новый мир построим"
            };
            return task;
        }

    }
}
