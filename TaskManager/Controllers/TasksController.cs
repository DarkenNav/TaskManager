using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskManager.Logic;
using TaskManager.Models.Tasks;

namespace TaskManager.Controllers
{
    public class TasksController : Controller
    {
        private TaskService _taskService;

        public TasksController(TaskService taskService) 
        {
            _taskService = taskService;
        }

        /// <summary>
        /// 1111 GET Tasks/NewTask
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult NewTask()
        {
            return View();
        }

        /// <summary>
        /// POST Tasks/NewTask
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult NewTask(TaskCreateViewModel task)
        {
            var taskId = 51;
            return RedirectToAction("Edit", new { id = taskId });
        }

        /// <summary>
        /// POST Tasks/Edit/{id}
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var task = _taskService.Get(id);
            var model = new TaskViewModel(task);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(TaskUpdateViewModel task)
        {
            return RedirectToAction("Edit", new { id = task.Id });
        }
    }
}
