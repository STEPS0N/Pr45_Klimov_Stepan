using API_Klimov.Context;
using Microsoft.AspNetCore.Mvc;
using API_Klimov.Model;
using API_Klimov.Context;
using Microsoft.AspNetCore.Mvc.Routing;

namespace API_Klimov.Controllers
{
    [Route("api/TasksController")]
    public class TasksController : Controller
    {
        ///<summary>
        ///Получение списка задач
        ///</summary>
        ///<remarks>Данный метод получает список задач, находящийся в базе данных</remarks>
        /// <response code="200">Список успешно получен</response>
        /// <response code="500">При выполнении запроса возникли ошибки</response>
        [Route("List")]
        [HttpGet]
        [ProducesResponseType(typeof(List<Model.Task>), 200)]
        [ProducesResponseType(500)]

        public ActionResult List()
        {
            try
            {
                IEnumerable<Model.Task> Tasks = new TaskContext().Tasks;
                return Json(Tasks);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        ///<summary>
        ///Получение задачи
        ///</summary>
        ///<remarks>Данный метод получает задачу, находящуюся в базе данных</remarks>
        /// <response code="200">Задача успешно получена</response>
        /// <response code="500">При выполнении запроса возникли ошибки</response>
        [Route("Item")]
        [HttpGet]
        [ProducesResponseType(typeof(Model.Task), 200)]
        [ProducesResponseType(500)]

        public ActionResult Item(int Id)
        {
            try
            {
                Model.Task Task = new TaskContext().Tasks.Where(x => x.Id == Id).First();
                return Json(Task);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        ///<summary>
        ///Получение одной задачи
        ///</summary>
        ///<remarks>Данный метод получает одну задачу, находящуюся в базе данных</remarks>
        /// <response code="200">Задача успешно получена</response>
        /// <response code="500">При выполнении запроса возникли ошибки</response>
        [Route("{Id}")]
        [HttpGet]
        [ProducesResponseType(typeof(Model.Task), 200)]
        [ProducesResponseType(500)]

        public ActionResult GetId(int Id)
        {
            try
            {
                Model.Task Task = new TaskContext().Tasks.Where(x => x.Id == Id).First();
                return Json(Task);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        ///<summary>
        ///Поиск задач по наименованию
        ///</summary>
        ///<remarks>Данный метод получает задачи, находящуюся в базе данных по наименованию</remarks>
        /// <response code="200">Задачи успешно получены</response>
        /// <response code="500">При выполнении запроса возникли ошибки</response>
        [Route("search")]
        [HttpGet]
        [ProducesResponseType(typeof(List<Model.Task>), 200)]
        [ProducesResponseType(500)]

        public ActionResult search(string search)
        {
            try
            {
                List<Model.Task> Task = new TaskContext().Tasks.Where(x => x.Name.ToLower().Contains(search.ToLower())).ToList();
                return Json(Task);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
