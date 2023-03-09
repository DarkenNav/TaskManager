using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.API.Models.Tasks;
using TaskManager.Logic;

namespace TaskManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private TaskService _taskService;

        public TasksController(TaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("{id}")]
        public ActionResult<TaskModel> Get(int id)
        {
            var task = _taskService.Get(id);
            var model = new TaskModel(task);

            return model;
        }
    }
}
