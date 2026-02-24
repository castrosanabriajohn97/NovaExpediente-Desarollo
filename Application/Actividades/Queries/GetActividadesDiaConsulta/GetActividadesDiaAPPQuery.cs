// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;
using System;

namespace NovaExpediente.Application.Actividades.Queries.GetActividadesDiaConsulta
{
    public class GetActividadesDiaAPPQuery : IRequest<string>
    {
        public DateTime Fecha { get; set; }
        public int IdIdioma { get; set; }
    }
}