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
            _db.Add(item);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var t = _db.TodoItems.Find(id);
            if (t != null)
            {
                _db.TodoItems.Remove(t);
                _db.SaveChanges();
            }
            else
            {
                throw new NullReferenceException("Data Tidak Ditemukan");
            }
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _db.TodoItems.ToList();
        }

        public TodoItem? GetById(int id)
        {
            return _db.TodoItems.Find(id);
        }

        public TodoItem? GetReminder()
        {
            return _db.TodoItems.Where(x => x.ReminderTime != null).OrderBy(x => x.ReminderTime).FirstOrDefault();
        }

        public void Update(TodoItem item)
        {
            _db.TodoItems.Update(item);
            _db.SaveChanges();
        }
    }
}
