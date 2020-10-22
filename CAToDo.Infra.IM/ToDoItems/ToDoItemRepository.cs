using CAToDo.Application.Interface.Data;
using CAToDo.Core.Exceptions;
using CAToDo.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CAToDo.Infra.EF.ToDoItems
{
    public class ToDoItemRepository : IToDoItemRepository
    {

        public static List<ToDoItem> Items;

        public ToDoItemRepository()
        {
            Items = new List<ToDoItem>();
        }

        public async Task<ToDoItem> CreateNewToDoItem(ToDoItem item)
        {
            Items.Add(item);

            return item;
        }

        public async Task<ToDoItem[]> GetAllToDoItems()
        {
            return Items.ToArray();
        }

        public async Task<ToDoItem> GetOneToDoItem(string title)
        {
            ToDoItem item = Items.Find(i => i.Title == title);

            if(item == null)
            {
                throw new ToDoItemNotFoundException($"Could not find ToDo Item with title: {title}");
            }

            return item;
        }
    }
}
