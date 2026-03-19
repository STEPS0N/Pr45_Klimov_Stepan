using API_Klimov.Context;
using API_Klimov.Context.AutoReviewContext;
using Microsoft.AspNetCore.Mvc;

namespace API_Klimov.Controllers.AutoReviewControllers
{
    [Route("api/AutoReviewControllers")]
    [ApiExplorerSettings(GroupName = "v2")]
    public class AutoReviewControllers : Controller
    {
        ///<summary>
        /// Метод добавления кузова
        /// </summary>
        /// <param name="bodyType">Данные о кузоваx</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод добавляет кузов в базу данных</remarks>
        [Route("AddBodyType")]
        [HttpPost]
        [ApiExplorerSettings(GroupName = "v2")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]

        public ActionResult AddBodyType([FromForm] Model.AutoReview.BodyTypes bodyType)
        {
            try
            {
                AutoReviewContext autoReviewContext = new AutoReviewContext();
                autoReviewContext.BodyTypes.Add(bodyType);
                autoReviewContext.SaveChanges();
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        ///<summary>
        /// Метод добавления марки авто
        /// </summary>
        /// <param name="brand">Данные о марке авто</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод добавляет марку в базу данных</remarks>
        [Route("AddBrand")]
        [HttpPost]
        [ApiExplorerSettings(GroupName = "v2")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]

        public ActionResult AddBrand([FromForm] Model.AutoReview.Brands brand)
        {
            try
            {
                AutoReviewContext autoReviewContext = new AutoReviewContext();
                autoReviewContext.Brands.Add(brand);
                autoReviewContext.SaveChanges();
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        ///<summary>
        /// Метод добавления двигателя
        /// </summary>
        /// <param name="engine">Данные о двигателе</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод добавляет двигатель в базу данных</remarks>
        [Route("AddEngine")]
        [HttpPost]
        [ApiExplorerSettings(GroupName = "v2")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]

        public ActionResult AddBrand([FromForm] Model.AutoReview.Engines engine)
        {
            try
            {
                AutoReviewContext autoReviewContext = new AutoReviewContext();
                autoReviewContext.Engines.Add(engine);
                autoReviewContext.SaveChanges();
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        ///<summary>
        /// Метод добавления модели авто
        /// </summary>
        /// <param name="model">Данные о моделях авто</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод добавляет модель в базу данных</remarks>
        [Route("AddModel")]
        [HttpPost]
        [ApiExplorerSettings(GroupName = "v2")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]

        public ActionResult AddModel([FromForm] Model.AutoReview.Models model)
        {
            try
            {
                AutoReviewContext autoReviewContext = new AutoReviewContext();
                autoReviewContext.Models.Add(model);
                autoReviewContext.SaveChanges();
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        ///<summary>
        /// Метод добавления владельца авто
        /// </summary>
        /// <param name="owner">Данные о владельцах авто</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод добавляет владельца в базу данных</remarks>
        [Route("AddOwner")]
        [HttpPost]
        [ApiExplorerSettings(GroupName = "v2")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]

        public ActionResult AddModel([FromForm] Model.AutoReview.Owners owner)
        {
            try
            {
                AutoReviewContext autoReviewContext = new AutoReviewContext();
                autoReviewContext.Owners.Add(owner);
                autoReviewContext.SaveChanges();
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        ///<summary>
        /// Метод добавления трансмиссии
        /// </summary>
        /// <param name="transmission">Данные о трансмиссии</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод добавляет трансмиссию в базу данных</remarks>
        [Route("AddTransmission")]
        [HttpPost]
        [ApiExplorerSettings(GroupName = "v2")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]

        public ActionResult AddTransmission([FromForm] Model.AutoReview.Transmissions transmission)
        {
            try
            {
                AutoReviewContext autoReviewContext = new AutoReviewContext();
                autoReviewContext.Transmissions.Add(transmission);
                autoReviewContext.SaveChanges();
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        ///<summary>
        /// Метод добавления комплектации
        /// </summary>
        /// <param name="trim">Данные о комплектации</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод добавляет комплектациию в базу данных</remarks>
        [Route("AddTrim")]
        [HttpPost]
        [ApiExplorerSettings(GroupName = "v2")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]

        public ActionResult AddTrim([FromForm] Model.AutoReview.Trims trim)
        {
            try
            {
                AutoReviewContext autoReviewContext = new AutoReviewContext();
                autoReviewContext.Trims.Add(trim);
                autoReviewContext.SaveChanges();
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        ///<summary>
        /// Метод добавления авто
        /// </summary>
        /// <param name="car">Данные об авто</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод добавляет авто в базу данных</remarks>
        [Route("AddCar")]
        [HttpPost]
        [ApiExplorerSettings(GroupName = "v2")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]

        public ActionResult AddCar([FromForm] Model.AutoReview.Cars car)
        {
            try
            {
                AutoReviewContext autoReviewContext = new AutoReviewContext();
                autoReviewContext.Cars.Add(car);
                autoReviewContext.SaveChanges();
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        /////<summary>
        ///// Метод обновления задачи
        ///// </summary>
        ///// <param name="Id">Идентификатор задачи</param>
        ///// <param name="Name">Название задачи</param>
        ///// <param name="Priority">Приоритет</param>
        ///// <param name="DateExecute">Дата выполнения</param>
        ///// <param name="Comment">Комментарий</param>
        ///// <param name="Done">Статус выполнения</param>
        ///// <returns>Статус выполнения запроса</returns>
        ///// <remarks>Данный метод добавляет задачу в базу данных</remarks>
        //[Route("Update")]
        //[HttpPut]
        //[ApiExplorerSettings(GroupName = "v3")]
        //[ProducesResponseType(200)]
        //[ProducesResponseType(500)]

        //public ActionResult Update([FromForm] int Id, [FromForm] string Name, [FromForm] string Priority,
        //    [FromForm] DateTime DateExecute, [FromForm] string Comment, [FromForm] bool Done)
        //{
        //    try
        //    {
        //        TaskContext taskContext = new TaskContext();

        //        var tasks = taskContext.Tasks.FirstOrDefault(x => x.Id == Id);

        //        if (tasks != null)
        //        {
        //            tasks.Name = Name;
        //            tasks.Priority = Priority;
        //            tasks.DateExecute = DateExecute;
        //            tasks.Comment = Comment;
        //            tasks.Done = Done;

        //            taskContext.SaveChanges();
        //            return StatusCode(200);
        //        }
        //        else
        //        {
        //            return StatusCode(500);
        //        }
        //    }
        //    catch
        //    {
        //        return StatusCode(500);
        //    }
        //}
    }
}
