using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAToDo.Application.UseCase.ToDoItem.Command
{
    public class NewToDoItemCommand : IRequest<CAToDo.Core.Models.ToDoItem>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
