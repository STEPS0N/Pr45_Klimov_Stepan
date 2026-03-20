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

        public ActionResult AddBodyType([FromBody] Model.AutoReview.BodyTypes bodyType)
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

        public ActionResult AddBrand([FromBody] Model.AutoReview.Brands brand)
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

        public ActionResult AddEngine([FromBody] Model.AutoReview.Engines engine)
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

        public ActionResult AddModel([FromBody] Model.AutoReview.Models model)
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

        public ActionResult AddOwner([FromBody] Model.AutoReview.Owners owner)
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

        public ActionResult AddTransmission([FromBody] Model.AutoReview.Transmissions transmission)
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

        public ActionResult AddTrim([FromBody] Model.AutoReview.Trims trim)
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

        public ActionResult AddCar([FromBody] Model.AutoReview.Cars car)
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

        [ApiExplorerSettings(GroupName = "v3")]
        ///<summary>
        /// Метод обновления кузова
        /// </summary>
        /// <param name="id">Код кузова</param>
        /// <param name="bodyType">Обновленные данные о кузове</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод обновляет данные кузова в базе данных</remarks>
        [Route("UpdateBodyType/{id}")]
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]

        public ActionResult UpdateBodyType(int id, [FromBody] Model.AutoReview.BodyTypes bodyType)
        {
            try
            {
                AutoReviewContext autoReviewContext = new AutoReviewContext();
                var existingBodyType = autoReviewContext.BodyTypes.Find(id);

                if (existingBodyType == null)
                {
                    return StatusCode(404, "Кузов с указанным ID не найден");
                }

                existingBodyType.Name = bodyType.Name;
                autoReviewContext.SaveChanges();
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [ApiExplorerSettings(GroupName = "v3")]
        ///<summary>
        /// Метод обновления марки
        /// </summary>
        /// <param name="id">Код марки</param>
        /// <param name="brand">Обновленные данные о марке</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод обновляет данные марки в базе данных</remarks>
        [Route("UpdateBrand/{id}")]
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]

        public ActionResult UpdateBrand(int id, [FromBody] Model.AutoReview.Brands upBrand)
        {
            try
            {
                AutoReviewContext autoReviewContext = new AutoReviewContext();
                var existingBrand = autoReviewContext.Brands.Find(id);

                if (existingBrand == null)
                {
                    return StatusCode(404, "Марка с указанным ID не найдена");
                }

                existingBrand.Name = upBrand.Name;
                autoReviewContext.SaveChanges();
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [ApiExplorerSettings(GroupName = "v3")]
        ///<summary>
        /// Метод обновления двигателя
        /// </summary>
        /// <param name="id">Код двигателя</param>
        /// <param name="engine">Обновленные данные о двигателе</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод обновляет данные двигателя в базе данных</remarks>
        [Route("UpdateEngine/{id}")]
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]

        public ActionResult UpdateEngine(int id, [FromBody] Model.AutoReview.Engines engine)
        {
            try
            {
                AutoReviewContext autoReviewContext = new AutoReviewContext();
                var existingEngine = autoReviewContext.Engines.Find(id);

                if (existingEngine == null)
                {
                    return StatusCode(404, "Двигатель с указанным ID не найден");
                }

                existingEngine.Type = engine.Type;
                existingEngine.Volume = engine.Volume;
                existingEngine.Power = engine.Power;
                existingEngine.FuelConsumption = engine.FuelConsumption;
                existingEngine.Torque = engine.Torque;
                autoReviewContext.SaveChanges();
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [ApiExplorerSettings(GroupName = "v3")]
        ///<summary>
        /// Метод обновления модели авто
        /// </summary>
        /// <param name="id">Код модели</param>
        /// <param name="model">Обновленные данные о модели авто</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод обновляет данные модели в базе данных</remarks>
        [Route("UpdateModel/{id}")]
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]

        public ActionResult UpdateModel(int id, [FromBody] Model.AutoReview.Models model)
        {
            try
            {
                AutoReviewContext autoReviewContext = new AutoReviewContext();
                var existingModel = autoReviewContext.Models.Find(id);

                if (existingModel == null)
                {
                    return StatusCode(404, "Модель с указанным ID не найдена");
                }

                existingModel.Name = model.Name;
                existingModel.Generation = model.Generation;
                existingModel.Class = model.Class;
                existingModel.BrandId = model.BrandId;
                autoReviewContext.SaveChanges();
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [ApiExplorerSettings(GroupName = "v3")]
        ///<summary>
        /// Метод обновления владельца авто
        /// </summary>
        /// <param name="id">Код владельца</param>
        /// <param name="owner">Обновленные данные о владельце авто</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод обновляет данные владельца в базе данных</remarks>
        [Route("UpdateOwner/{id}")]
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]

        public ActionResult UpdateOwner(int id, [FromBody] Model.AutoReview.Owners owner)
        {
            try
            {
                AutoReviewContext autoReviewContext = new AutoReviewContext();
                var existingOwner = autoReviewContext.Owners.Find(id);

                if (existingOwner == null)
                {
                    return StatusCode(404, "Владелец с указанным ID не найден");
                }

                existingOwner.Email = owner.Email;
                existingOwner.LastName = owner.LastName;
                existingOwner.FirstName = owner.FirstName;
                existingOwner.Phone = owner.Phone;
                existingOwner.Role = owner.Role;
                autoReviewContext.SaveChanges();
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [ApiExplorerSettings(GroupName = "v3")]
        ///<summary>
        /// Метод обновления трансмиссии
        /// </summary>
        /// <param name="id">Код трансмиссии</param>
        /// <param name="transmission">Обновленные данные о трансмиссии</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод обновляет данные трансмиссии в базе данных</remarks>
        [Route("UpdateTransmission/{id}")]
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]

        public ActionResult UpdateTransmission(int id, [FromBody] Model.AutoReview.Transmissions transmission)
        {
            try
            {
                AutoReviewContext autoReviewContext = new AutoReviewContext();
                var existingTransmission = autoReviewContext.Transmissions.Find(id);

                if (existingTransmission == null)
                {
                    return StatusCode(404, "Трансмиссия с указанным ID не найдена");
                }

                existingTransmission.GearboxType = transmission.GearboxType;
                existingTransmission.DriveType = transmission.DriveType;
                autoReviewContext.SaveChanges();
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [ApiExplorerSettings(GroupName = "v3")]
        ///<summary>
        /// Метод обновления комплектации
        /// </summary>
        /// <param name="id">Код комплектации</param>
        /// <param name="trim">Обновленные данные о комплектации</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод обновляет данные комплектации в базе данных</remarks>
        [Route("UpdateTrim/{id}")]
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]

        public ActionResult UpdateTrim(int id, [FromBody] Model.AutoReview.Trims trim)
        {
            try
            {
                AutoReviewContext autoReviewContext = new AutoReviewContext();
                var existingTrim = autoReviewContext.Trims.Find(id);

                if (existingTrim == null)
                {
                    return StatusCode(404, "Комплектация с указанным ID не найдена");
                }

                existingTrim.Name = trim.Name;
                existingTrim.Equipment = trim.Equipment;
                autoReviewContext.SaveChanges();
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [ApiExplorerSettings(GroupName = "v3")]
        ///<summary>
        /// Метод обновления авто
        /// </summary>
        /// <param name="id">Код авто</param>
        /// <param name="car">Обновленные данные об авто</param>
        /// <returns>Статус выполнения запроса</returns>
        /// <remarks>Данный метод обновляет данные авто в базе данных</remarks>
        [Route("UpdateCar/{id}")]
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]

        public ActionResult UpdateCar(int id, [FromBody] Model.AutoReview.Cars car)
        {
            try
            {
                AutoReviewContext autoReviewContext = new AutoReviewContext();
                var existingCar = autoReviewContext.Cars.Find(id);

                if (existingCar == null)
                {
                    return StatusCode(404, "Автомобиль с указанным ID не найден");
                }

                existingCar.Year = car.Year;
                existingCar.Price = car.Price;
                existingCar.VIN = car.VIN;
                existingCar.Mileage = car.Mileage;
                existingCar.Condition = car.Condition;
                existingCar.ModelId = car.ModelId;
                existingCar.EngineId = car.EngineId;
                existingCar.TransmissionId = car.TransmissionId;
                existingCar.TrimId = car.TrimId;
                existingCar.OwnerId = car.OwnerId;
                existingCar.BodyTypeId = car.BodyTypeId;
                autoReviewContext.SaveChanges();
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
