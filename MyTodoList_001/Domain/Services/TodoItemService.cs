using MyTodoList_001.Domain.Entities;
using MyTodoList_001.Domain.Repoitories;

namespace MyTodoList_001.Domain.Services
{
    public class TodoItemService : ITodoItemServices
    {
        protected TodoDbContext _db;

        public TodoItemService(TodoDbContext db)
        {
            _db = db;
        }

        public void Create(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public TodoItem GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int? GetReminder()
        {
            throw new NotImplementedException();
        }

        public void Update(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
