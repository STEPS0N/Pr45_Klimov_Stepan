using System.ComponentModel.DataAnnotations;

namespace API_Klimov.Model.AutoReview
{
    public class BodyTypes
    {
        /// <summary>
        /// Код
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Тип кузова
        /// </summary>
        public string Name { get; set; }

        public virtual ICollection<Cars> Cars { get; set; }
    }
}
