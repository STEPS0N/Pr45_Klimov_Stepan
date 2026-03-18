using API_Klimov.Context;
using API_Klimov.Model;
using Microsoft.AspNetCore.Mvc;

namespace API_Klimov.Controllers
{
    [Route("api/UsersController")]
    [ApiExplorerSettings(GroupName = "v2")]
    public class UsersController : Controller
    {
        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        /// <param name="Login">Логин пользователя</param>
        /// <param name="Password">Пароль пользователя</param>
        /// <returns>Данный метод прднозначен для авторизации пользователя на сайте</returns>
        /// <response code="200">Пользователь успешно авторизован</response>
        /// <response code="403">Ошибка запроса данные не указаны</response>
        /// <response code="500">При выполнении запроса возникли ошибки</response>
        [Route("SignIn")]
        [HttpPost]
        [ProducesResponseType(typeof(Users), 200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public ActionResult SignIn([FromForm] string Login, [FromForm]  string Password)
        {
            if (Login == null || Password == null)
                return StatusCode(403);

            try
            {
                Users User = new UsersContext().Users.Where(x => x.Login == Login &&
                    x.Password == Password).First();
                return Json(User);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
