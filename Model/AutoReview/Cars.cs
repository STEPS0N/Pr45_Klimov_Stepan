using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Klimov.Model.AutoReview
{
    public class Cars
    {
        /// <summary>
        /// Код
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Год выпуска
        /// </summary>
        public string Year { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// VIN-код
        /// </summary>
        public string VIN { get; set; }
        /// <summary>
        /// Пробег
        /// </summary>
        public int Mileage { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int Condition { get; set; }
        /// <summary>
        /// Код модели
        /// </summary>
        public int ModelId { get; set; }
        /// <summary>
        /// Код двигателя
        /// </summary>
        public int EngineId { get; set; }
        /// <summary>
        /// Код трансмиссии
        /// </summary>
        public int TransmissionId { get; set; }
        /// <summary>
        /// Код комплектации
        /// </summary>
        public int TrimId { get; set; }
        /// <summary>
        /// Код владельца
        /// </summary>
        public int OwnerId { get; set; }
        /// <summary>
        /// Код кузова
        /// </summary>
        public int BodyTypeId { get; set; }

        [ForeignKey("ModelId")]
        public virtual Models Model { get; set; }

        [ForeignKey("EngineId")]
        public virtual Engines Engine { get; set; }

        [ForeignKey("TransmissionId")]
        public virtual Transmissions Transmission { get; set; }

        [ForeignKey("TrimId")]
        public virtual Trims Trim { get; set; }

        [ForeignKey("OwnerId")]
        public virtual Owners Owner { get; set; }

        [ForeignKey("BodyTypeId")]
        public virtual BodyTypes BodyType { get; set; }
    }
}
