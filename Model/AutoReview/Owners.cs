using System.ComponentModel.DataAnnotations;

namespace API_Klimov.Model.AutoReview
{
    public class Owners
    {
        /// <summary>
        /// Код
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Логин (Email)
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Роль
        /// </summary>
        public string Role { get; set; }

        public virtual ICollection<Cars> Cars { get; set; }
    }
}
