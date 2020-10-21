using CAToDo.Application.Interface.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CAToDo.Application.UseCase.ToDoItem.Query
{
    public class GetAllToDoItemsRequestHandler : IRequestHandler<GetAllToDoItemsRequest, Core.Models.ToDoItem[]>
    {
        private IToDoItemRepository _repo;

        public GetAllToDoItemsRequestHandler(IToDoItemRepository repo)
        {
            _repo = repo;
        }

        public async Task<Core.Models.ToDoItem[]> Handle(GetAllToDoItemsRequest request, CancellationToken cancellationToken)
        {
            return await _repo.GetAllToDoItems();
        }
    }
}
