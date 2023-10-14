using Application.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Runtime.InteropServices;

//https://github.com/Rezakazemi890/Clean-Architecture-CQRS/blob/main/CleanArchitectureCQRS.Api/Controllers/SampleEntityController.cs
namespace Api
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/workitem")]
    //[Route("[controller]")]
    [Produces("application/json")]
    public class WorkItemsController : BaseController
    {
        public WorkItemsController()
        {

        }

        [HttpPost("request")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [SwaggerOperation(
            "Returns a collection of a work item's attachments.",
            Tags = new[] { "3. Work Item Attachments" },
            OperationId = "GetManyWorkItemAttachments")]
        public async Task<ActionResult> Post([FromBody] CreateWorkItemCommand command)
        {
            return CreatedAtAction("", new { }, null);
        }

        [HttpGet("request")]
        public async Task<ActionResult> Get()
        {
            return Ok("hi");
        }

        [HttpGet()]
        public string TestGet()
        {
            return "hi";
        }
    }
}