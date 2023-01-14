using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoApi.Controllers
{
    [Route("/")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoItemController(ITodoService todoItemService)
        {
            _todoService = todoItemService;
        }
        [HttpGet]
        public async Task<IActionResult> GetTodoItemList()
        {
            var result = await _todoService.GetTodoItemList();

            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetTodoItem(long id)
        {
            var result = await _todoService.GetTodoItem(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddTodoItem([FromBody] TodoItem TodoItem)
        {
            var result = await _todoService.CreateTodoItem(TodoItem);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTodoItem([FromBody] TodoItem TodoItem)
        {
            var result = await _todoService.UpdateTodoItem(TodoItem);

            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteTodoItem(long id)
        {
            var result = await _todoService.DeleteTodoItem(id);

            return Ok(result);
        }
    }
}
