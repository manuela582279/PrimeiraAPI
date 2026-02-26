using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI.Controllers
{
    [Route("api/statusAPI")] //Rota base: /api/health
    [ApiController] //Ativa validação automatica e outras funcionalidades de API 
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            
           //Retorna um status 200 OK 
            return Ok(new
            {
                status = "UP",
                service = "Primeira API OK",
                date = DateTime.Now,
            }
                );
        }
    }
}
