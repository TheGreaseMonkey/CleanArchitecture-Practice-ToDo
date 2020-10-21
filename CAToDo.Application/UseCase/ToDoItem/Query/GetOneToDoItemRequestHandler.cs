using CAToDo.Application.Interface.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CAToDo.Application.UseCase.ToDoItem.Query
{
    public class GetOneToDoItemRequestHandler : IRequestHandler<GetOneToDoItemRequest, Core.Models.ToDoItem>
    {
        private IToDoItemRepository _repo;

        public GetOneToDoItemRequestHandler(IToDoItemRepository repo)
        {
            _repo = repo;
        }

        public async Task<Core.Models.ToDoItem> Handle(GetOneToDoItemRequest request, CancellationToken cancellationToken)
        {
            return await _repo.GetOneToDoItem(request.Title);
        }
    }
}
