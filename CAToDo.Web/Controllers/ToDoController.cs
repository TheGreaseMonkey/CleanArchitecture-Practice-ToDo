using System.Threading.Tasks;
using CAToDo.Application.UseCase.ToDoItem.Command;
using CAToDo.Application.UseCase.ToDoItem.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CAToDo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private IMediator _mediator;

        public ToDoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<ToDoController>
        [HttpGet]
        public async Task<Core.Models.ToDoItem[]> Get()
        {
            return await _mediator.Send(new GetAllToDoItemsRequest());
        }

        // GET api/<ToDoController>/testy
        [HttpGet("{name}")]
        public async Task<Core.Models.ToDoItem> Get(string name)
        {
            return await _mediator.Send(new GetOneToDoItemRequest { Title = name });
        }

        // POST api/<ToDoController>
        [HttpPost]
        public async Task<Core.Models.ToDoItem> Post([FromBody] NewToDoItemCommand item)
        {
            // Maybe add some validation later
            return await _mediator.Send(item);
        }

        // PUT api/<ToDoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ToDoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
