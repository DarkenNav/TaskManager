using TaskManager.Logic.Models.Tasks;

namespace TaskManager.Models.Tasks
{
    public class TaskViewModel
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public int? ContactorId { get; set; }
        public string Description { get; set; }


        public TaskViewModel() { }

        public TaskViewModel(TaskDTO task) 
        { 
            Id = task.Id;
            Subject = task.Subject;
            Description = task.Description;
        }
    }
}
