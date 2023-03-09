using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Models.Tasks
{
    public class TaskUpdateViewModel
    {
        [FromRoute]
        public int Id { get; set; }
        public string Subject { get; set; }
        public int? ContactorId { get; set; }
        public string Description { get; set; }
    }
}
