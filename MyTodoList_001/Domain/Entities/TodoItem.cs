namespace MyTodoList_001.Domain.Entities
{
    public class TodoItem
    {
        private DateTime? _reminderTime;
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public DateOnly DueDate { get; set; }

        public DateTime? ReminderTime
        {
            get { return _reminderTime; }
            set
            { _reminderTime = (value != null) ? DateTime.SpecifyKind(value.Value, DateTimeKind.Utc) : null; }
        }
        public string Status { get; set; } = "Belum Selesai";
    }
}
