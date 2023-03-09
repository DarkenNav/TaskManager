namespace TaskManager.Models.Tasks
{
    public class TaskCreateViewModel
    {
        public string Subject { get; set; }
        public int? ContactorId { get; set; }
        public string Description { get; set; }
    }
}
