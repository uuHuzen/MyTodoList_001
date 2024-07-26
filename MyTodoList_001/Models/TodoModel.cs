using MyTodoList_001.Domain.Entities;

namespace MyTodoList_001.Models
{
    public class TodoModel
    {
        public IEnumerable<TodoItem> Items { get; set; }
        public TodoItem Item { get; set; }

    }
}
