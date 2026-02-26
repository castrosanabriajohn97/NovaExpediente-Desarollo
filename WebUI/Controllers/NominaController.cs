// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NovaExpediente.Application.Nomina.Queries.GetSaldoVacaciones;


using System.Threading.Tasks;
namespace NovaExpediente.WebUI.Controllers
{
    [Authorize]
    public class NominaController : BaseController
    {
        [HttpGet]
        
        public async Task<ActionResult<VacacionesNominaVm>> GetVacacionesNomina(int IdNomina)
        {
  
            return Ok(await Mediator.Send(new GetVacacionesNominaListQuery { IdNomina = IdNomina }));

        }



    }
}
