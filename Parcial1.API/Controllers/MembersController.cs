using Microsoft.AspNetCore.Mvc;
using Parcial1.API.Data;

namespace Parcial1.API.Controllers
{
    [ApiController]
    [Route("/api/universities")]
    public class MembersController:ControllerBase
    {
        private readonly DataContext dataContext;

        public MembersController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}
