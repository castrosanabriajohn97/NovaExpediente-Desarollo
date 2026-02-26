// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;
using System.Collections.Generic;

namespace NovaExpediente.Application.VacunacionColaboradores.Queries.GetVacunacionColaboradorReporte
{
   public class GetVacunacionColaboradorReporteListQuery : IRequest<VacunacionColaboradorReporteVm>
    {

        public int IdColaborador { get; set; }
        public List<string> Roles { get; set; }
    }
}





