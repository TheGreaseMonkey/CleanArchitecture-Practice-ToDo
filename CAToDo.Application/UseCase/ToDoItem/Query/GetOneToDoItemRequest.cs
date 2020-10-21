using MediatR;

namespace CAToDo.Application.UseCase.ToDoItem.Query
{
    public class GetOneToDoItemRequest : IRequest<Core.Models.ToDoItem>
    {
        public string Title { get; set; }
    }
}
