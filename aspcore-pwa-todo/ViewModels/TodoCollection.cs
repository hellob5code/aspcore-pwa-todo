using System.Collections.Generic;

namespace aspcore_pwa_todo.ViewModels
{
    public class TodoCollection
    {
        public IEnumerable<TodoItem> Items { get; set; }
    }
}