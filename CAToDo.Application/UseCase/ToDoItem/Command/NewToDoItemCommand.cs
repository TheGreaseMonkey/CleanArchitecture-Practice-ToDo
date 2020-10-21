using MediatR;

namespace CAToDo.Application.UseCase.ToDoItem.Command
{
    public class NewToDoItemCommand : IRequest<Core.Models.ToDoItem>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
