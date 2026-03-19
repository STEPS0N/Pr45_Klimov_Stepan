using System.Threading.Tasks;
using API_Klimov.Context;
using API_Klimov.Model;
using Microsoft.AspNetCore.Mvc;

namespace API_Klimov.Controllers
{
    [Route("api/TasksController")]
    [ApiExplorerSettings(GroupName = "v1")]
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

        ///<summary>
        /// Метод добавления задачи
        /// </summary>
        /// <param name="task">Данные о задачи</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод добавляет задачу в базу данных</remarks>
        [Route("Add")]
        [HttpPut]
        [ApiExplorerSettings(GroupName = "v3")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]

        public ActionResult Add([FromForm] Model.Task task)
        {
            try
            {
                TaskContext taskContext = new TaskContext();
                taskContext.Tasks.Add(task);
                taskContext.SaveChanges();
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        ///<summary>
        /// Метод обновления задачи
        /// </summary>
        /// <param name="Id">Идентификатор задачи</param>
        /// <param name="Name">Название задачи</param>
        /// <param name="Priority">Приоритет</param>
        /// <param name="DateExecute">Дата выполнения</param>
        /// <param name="Comment">Комментарий</param>
        /// <param name="Done">Статус выполнения</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод добавляет задачу в базу данных</remarks>
        [Route("Update")]
        [HttpPut]
        [ApiExplorerSettings(GroupName = "v3")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]

        public ActionResult Update([FromForm] int Id, [FromForm] string Name, [FromForm] string Priority,
            [FromForm] DateTime DateExecute, [FromForm] string Comment, [FromForm] bool Done)
        {
            try
            {
                TaskContext taskContext = new TaskContext();

                var tasks = taskContext.Tasks.FirstOrDefault(x => x.Id == Id);

                if (tasks != null)
                {
                    tasks.Name = Name;
                    tasks.Priority = Priority;
                    tasks.DateExecute = DateExecute;
                    tasks.Comment = Comment;
                    tasks.Done = Done;

                    taskContext.SaveChanges();
                    return StatusCode(200);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
