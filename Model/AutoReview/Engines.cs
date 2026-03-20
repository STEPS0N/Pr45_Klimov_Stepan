using System.ComponentModel.DataAnnotations;

namespace API_Klimov.Model.AutoReview
{
    public class Engines
    {
        /// <summary>
        /// Код
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Тип двигателя
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Объём двигателя
        /// </summary>
        public decimal Volume { get; set; }
        /// <summary>
        /// Мощность двигателя
        /// </summary>
        public int Power { get; set; }
        /// <summary>
        /// Расход двигателя
        /// </summary>
        public decimal FuelConsumption { get; set; }
        /// <summary>
        /// Крутящий момент
        /// </summary>
        public int Torque { get; set; }
    }
}
