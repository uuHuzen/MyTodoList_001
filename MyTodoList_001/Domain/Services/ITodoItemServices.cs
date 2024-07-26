using MyTodoList_001.Domain.Entities;

namespace MyTodoList_001.Domain.Services
{
    public interface ITodoItemServices
    {
        IEnumerable<TodoItem> GetAll();
        TodoItem GetById(int id);
        void Create(TodoItem item);
        void Update(TodoItem item);
        void Delete(int id);
        int? GetReminder();
    }
}
