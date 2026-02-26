// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NovaExpediente.Application.FuncionesAdministrativas.Queries.GetBitacoraVacaciones;
using System.Threading.Tasks;

namespace NovaExpediente.WebUI.Controllers
{
    [Authorize]
    public class BitacoraVacacionesController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<string>> GetBitacoraVacaciones()
        {
            return Ok(await Mediator.Send(new GetBitacoraVacacionesQuery()));
        }
    }
}
