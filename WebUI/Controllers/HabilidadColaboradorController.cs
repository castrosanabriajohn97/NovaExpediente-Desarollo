// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NovaExpediente.Application.HabilidadesColaborador.Queries.GetListaHabilidadesColaborador;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace NovaExpediente.WebUI.Controllers
{
    [SwaggerTag("Colaborador - Habilidades blandas")]

    [Authorize]
    public class HabilidadColaboradorController : BaseController
    {
        [HttpGet]
        
        public async Task<ActionResult<HabilidadColaboradorListVm>> GetHabilidadesColaborador(int id)
        {
            return Ok(await Mediator.Send(new GetHabilidadColaboradorListQuery { Id = id }));
        }

    }
}
