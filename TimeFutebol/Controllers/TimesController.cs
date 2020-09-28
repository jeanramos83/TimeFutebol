using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeFutebol.Model;

namespace TimeFutebol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Lista dos times");
        }

        [HttpPost]
        public async Task<IActionResult> Post(CadastroTimes cadastro)
        {
            _repository.InserirTime;
            return Ok("Novo time criado com sucesso!!");
        }
    }

    
}
