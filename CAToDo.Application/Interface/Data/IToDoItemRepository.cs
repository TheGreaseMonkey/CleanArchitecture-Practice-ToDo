using System.Threading.Tasks;

namespace CAToDo.Application.Interface.Data
{
    public interface IToDoItemRepository
    {
        Task<Core.Models.ToDoItem> CreateNewToDoItem(Core.Models.ToDoItem item);
        Task<Core.Models.ToDoItem[]> GetAllToDoItems();
    }
}
