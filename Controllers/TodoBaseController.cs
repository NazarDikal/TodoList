using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Claims;

namespace TodoList.Controllers
{
    public abstract class TodoBaseController : Controller
    {
        protected int CurrentUserId => int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)); 
    }
}
