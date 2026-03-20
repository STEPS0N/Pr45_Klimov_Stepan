using System.ComponentModel.DataAnnotations;

namespace API_Klimov.Model.AutoReview
{
    public class Brands
    {
        /// <summary>
        /// Код
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Название марки
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Страна
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Год основания
        /// </summary>
        public int FoundedYear { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
    }
}
