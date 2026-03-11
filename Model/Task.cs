namespace API_Klimov.Model
{
    /// <summary>
    /// Задача
    /// </summary>
    public class Task
    {
        /// <summary>
        /// Код
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название задачи
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Приоритет задачи
        /// </summary>
        public string Priority { get; set; }
        /// <summary>
        /// Дата выполнения задачи
        /// </summary>
        public DateTime DateExecute { get; set; }
        /// <summary>
        /// Комментарий к задаче
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Статус выполнения задачи
        /// </summary>
        public bool Done { get; set; }
    }
}
