using System.ComponentModel.DataAnnotations;

namespace API_Klimov.Model.AutoReview
{
    public class Transmissions
    {
        /// <summary>
        /// Код
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Тип КПП
        /// </summary>
        public string GearboxType { get; set; }
        /// <summary>
        /// Тип привода
        /// </summary>
        public string DriveType { get; set; }
    }
}
