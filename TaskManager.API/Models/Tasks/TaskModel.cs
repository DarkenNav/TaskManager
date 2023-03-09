using TaskManager.Logic.Models.Tasks;

namespace TaskManager.API.Models.Tasks
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public int? ContactorId { get; set; }
        public string Description { get; set; }


        public TaskModel() { }

        public TaskModel(TaskDTO task) 
        { 
            Id = task.Id;
            Subject = task.Subject;
            Description = task.Description;
        }
    }
}
