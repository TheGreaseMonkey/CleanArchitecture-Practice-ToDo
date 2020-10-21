using MediatR;
using System.Threading.Tasks;
using System.Threading;
using CAToDo.Application.Interface.Data;

namespace CAToDo.Application.UseCase.ToDoItem.Command
{
    public class CreateNewToDoItemHandler : IRequestHandler<NewToDoItemCommand, CAToDo.Core.Models.ToDoItem>
    {

        private IToDoItemRepository _repo = null;

        public CreateNewToDoItemHandler(IToDoItemRepository repo)
        {
            _repo = repo;
        }

        public async Task<Core.Models.ToDoItem> Handle(NewToDoItemCommand request, CancellationToken cancellationToken)
        {
            Core.Models.ToDoItem toDoItem = new Core.Models.ToDoItem(request.Title, request.Description);

            await _repo.CreateNewToDoItem(toDoItem);

            return toDoItem;
        }
    }
}
