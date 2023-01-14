using System;
using TodoApi.Models;

namespace TodoApi.Services
{
    public class TodoService : ITodoService
    {
        private readonly IDbService _dbService;

        public TodoService(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<bool> CreateTodoItem(TodoItem todoItem)
        {
            var result =
            await _dbService.EditData(
                "INSERT INTO public.todo(name, iscomplete) VALUES (@Name, @IsComplete)",
                todoItem);
            return true;
        }

        public async Task<bool> DeleteTodoItem(long id)
        {
            var deleteUser = await _dbService.EditData("DELETE FROM public.todo WHERE id=@Id", new { id });
            return true;
        }

        public async Task<TodoItem> GetTodoItem(long id)
        {
            var todoItem = await _dbService.GetAsync<TodoItem>("SELECT * FROM public.todo where id=@id", new { id });
            return todoItem;
        }

        public async Task<List<TodoItem>> GetTodoItemList()
        {
            var todoList = await _dbService.GetAll<TodoItem>("SELECT * FROM public.todo", new { });
            return todoList;
        }

        public async Task<TodoItem> UpdateTodoItem(TodoItem todoItem)
        {
            var updateTodoItem =
            await _dbService.EditData(
                "Update public.todo SET name=@Name, iscomplete=@IsComplete WHERE id=@Id",
                todoItem);
            return todoItem;
        }
    }
}
