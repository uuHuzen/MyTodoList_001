namespace MyTodoList_001.Domain.Entities
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public DateOnly DueDate { get; set; }
        public DateTime ReminderTime { get; set; }
    }
}
