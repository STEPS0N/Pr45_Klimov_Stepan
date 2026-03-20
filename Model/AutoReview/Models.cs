using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Klimov.Model.AutoReview
{
    public class Models
    {
        /// <summary>
        /// Код
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Название модели
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Поколение
        /// </summary>
        public string Generation { get; set; }
        /// <summary>
        /// Класс
        /// </summary>
        public int Class { get; set; }
        /// <summary>
        /// Код марки
        /// </summary>
        public int BrandId { get; set; }
    }
}
