// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Nomina.Queries.GetSaldoVacaciones
{
    public class GetVacacionesNominaListQuery : IRequest<VacacionesNominaVm>
    {
        public int IdNomina { get; set; }
    }
}
