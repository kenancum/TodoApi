using TodoApi.Models;

namespace TodoApi.Services
{
    public interface ITodoService
    {
        Task<bool> CreateTodoItem(TodoItem todoItem);
        Task<TodoItem> GetTodoItem(long id);
        Task<List<TodoItem>> GetTodoItemList();
        Task<TodoItem> UpdateTodoItem(TodoItem todoItem);
        Task<bool> DeleteTodoItem(long id);
    }
}
