using TodoWebApp.Database;
using TodoWebApp.Services.Dtos;

namespace TodoWebApp.Services
{
    public class TodoService
    {
        public List<TodoDto> GetTodos(){

            var result = InMemoryDatabase.Todos.Select(todo =>
                   new TodoDto
                   {
                       Id = todo.Id,
                       Description = todo.Description,
                       DueDate = todo.DueDate,
                       Category = InMemoryDatabase.Categories.Single(c => c.Id == todo.Id).Name,
                       Status = InMemoryDatabase.Statuses.Single(s => s.Id == todo.StatusId).Name
                   }
               ).ToList();

            return result;
        }
    }
}
