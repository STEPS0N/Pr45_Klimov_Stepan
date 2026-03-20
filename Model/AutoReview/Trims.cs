using System.ComponentModel.DataAnnotations;

namespace API_Klimov.Model.AutoReview
{
    public class Trims
    {
        /// <summary>
        /// Код
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Уровень оснащения
        /// </summary>
        public string Equipment { get; set; }
    }
}
