using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.API.Models;

namespace Task.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        //CREATE =>POST
        //READ   =>GET
        //UPDATE =>PUT/PATCH
        //DELETE =>DELETE

        //in memory  store

         public static readonly List<TodoItem> _todoItems=[];
        //GET api/tasks

        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> Get()
        {
            return Ok(_todoItems);
        }

        //GET api/task/1

        [HttpGet("{id}")]
         public ActionResult<TodoItem> Get(int id)
         {
           var todoItem = _todoItems.FirstOrDefault(x => x.Id == id);
            if (todoItem != null)
            {
                return Ok(todoItem);
            }
            return Ok(todoItem);
         }

        //POST api/tasks



       

        





        








    }
}
