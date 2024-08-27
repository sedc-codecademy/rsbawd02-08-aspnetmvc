using TodoWebApp.Database.Entites;

namespace TodoWebApp.Database
{
    public static class InMemoryDatabase
    {
        private static int todoLastId;
        public static List<Category> Categories { get; set; }
        public static List<Status> Statuses { get; set; }
        public static List<Todo> Todos { get; set; }

        static InMemoryDatabase()
        {
            LoadCategories();
            LoadStatuses();
            LoadTodos();
            todoLastId = 3;
        }

        private static void LoadCategories()
        {

            Categories = new List<Category> {
             new Category {
                 Id = 1,
                 Name = "Home"
             },

             new Category {
                 Id = 2,
                 Name  = "Work"
             },

             new Category {
                 Id= 3,
                 Name = "Exercise"
             }

            };
        }
        private static void LoadStatuses() {
            Statuses = new List<Status>
            {
                new Status { Id= 1, Name="Open"},
                new Status { Id =2, Name="Closed"}
            };
        }

        private static void LoadTodos() {
            Todos = new List<Todo> { 
                new Todo { Id=1, Description = "Make coffee", CategoryId=1, StatusId=1, DueDate = DateTime.Now.AddDays(1) },
                new Todo { Id=2, Description = "Pay bills", CategoryId=2, StatusId=1, DueDate = DateTime.Now.AddDays(1) }

            };
        }

        private static void Save(Todo todo) {

            if (todo.Id == 0)
            {
                todo.Id = ++todoLastId;
                Todos.Add(todo);
            }
            else {

                var toUpdate = Todos.Single(t => t.Id == todo.Id);
                toUpdate = todo;
            }
        
        }


    }
}
