using TodoWebApp.Database;
using TodoWebApp.Database.Entites;
using TodoWebApp.Services.Dtos;

namespace TodoWebApp.Services
{
    public class TodoService
    {
        public List<TodoDto> GetTodos(int? categoryId, int? statusId)
        {
            var todos = InMemoryDatabase.Todos;

            if (categoryId.HasValue && categoryId.Value != 0)
                todos = todos.Where(t => t.CategoryId == categoryId.Value).ToList();

            if (statusId.HasValue && statusId.Value != 0)
                todos = todos.Where(t => t.StatusId == statusId.Value).ToList();


            var result = todos.Select(todo =>
                   new TodoDto
                   {
                       Id = todo.Id,
                       Description = todo.Description,
                       DueDate = todo.DueDate,
                       Category = InMemoryDatabase.Categories.Single(c => c.Id == todo.CategoryId).Name,
                       Status = InMemoryDatabase.Statuses.Single(s => s.Id == todo.StatusId).Name
                   }
               ).ToList();

            return result;
        }

        public void AddTodo(CreateTodoDto createTodoDto) {

            var newTodo = new Todo
            {
                Id = 0,
                Description = createTodoDto.Description,
                DueDate = createTodoDto.DueDate,
                CategoryId = createTodoDto.CategoryId,
                StatusId = 1
            };

            InMemoryDatabase.Save(newTodo);
        }

        public void MarkCompleted(int id)
        {
            var todoToComplete = InMemoryDatabase.Todos.Single(t => t.Id == id);
            todoToComplete.StatusId = 2;
            InMemoryDatabase.Save(todoToComplete);            
        }

        public void RemoveCompleted()
        {
            var todosToRemove = InMemoryDatabase.Todos.Where(t => t.StatusId == 2).ToList();
            foreach (var toRemove in todosToRemove)
            {
                InMemoryDatabase.Todos.Remove(toRemove);
            }
        }
    }
}
