using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem
            {
                Title = "Aprender ASP.NET CORE",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item2 = new TodoItem
            {
                Title = "Construir aplicações incríveis",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };
            return	Task.FromResult(new[] {item1,item2});
        }

        public async Task<bool> AddItemAsync(TodoItem newItem)
        {
            return false;
        }
        public async Task<bool> MarkDoneAsync(Guid id)
        {
            return false;
        }
    }
}
