// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NovaExpediente.Application.ProyectoBasesDatos.Queries.GetListaProyectoBaseDatos;
using System.Threading.Tasks;
namespace NovaExpediente.WebUI.Controllers
{
    [Authorize]
    public class ProyectoBaseDatosController : BaseController
    {
        [HttpGet]
        
        public async Task<ActionResult<ProyectoBaseDatosListVm>> GetProyectoBaseDatos(int id)
        {
            return Ok(await Mediator.Send(new GetProyectoBaseDatosListQuery { Id = id }));
        }

    }
}
