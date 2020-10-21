using MediatR;

namespace CAToDo.Application.UseCase.ToDoItem.Query
{
    public class GetAllToDoItemsRequest : IRequest<Core.Models.ToDoItem[]>
    {
    }
}
