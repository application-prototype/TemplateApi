using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://github.com/Rezakazemi890/Clean-Architecture-CQRS/blob/main/CleanArchitectureCQRS.Api/Controllers/BaseController.cs
namespace Api
{
    [ApiController]
    //[Route("api/[controller]")]
    public abstract class BaseController : ControllerBase
    {
        protected ActionResult<TResult> OkOrNotFound<TResult>(TResult result)
            => result is null ? NotFound() : Ok(result);
    }
}
