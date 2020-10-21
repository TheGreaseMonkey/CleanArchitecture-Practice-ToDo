using CAToDo.Application.Interface.Data;
using CAToDo.Core.Models;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace CAToDo.Infra.EF.ToDoItems
{
    public class ToDoItemRepository : IToDoItemRepository
    {

        public static ConcurrentDictionary<string,ToDoItem> Items;

        public ToDoItemRepository()
        {
            Items = new ConcurrentDictionary<string, ToDoItem>();
        }

        public async Task<ToDoItem> CreateNewToDoItem(ToDoItem item)
        {
            if (Items.ContainsKey(item.Title))
            {
                Items[item.Title] = item;
            }
            else
            {
                Items.TryAdd(item.Title, item);
            }

            return item;
        }
    }
}
