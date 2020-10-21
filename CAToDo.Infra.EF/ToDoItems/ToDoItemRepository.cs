using CAToDo.Application.Interface.Data;
using CAToDo.Core.Models;
using System.Collections.Concurrent;
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
            List<ToDoItem> items = new List<ToDoItem>();

            foreach (var i in Items)
            {
                items.Add(i);
            }

            return items.ToArray();
        }
    }
}
