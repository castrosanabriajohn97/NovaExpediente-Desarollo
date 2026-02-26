// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Actividades.Queries.GetActividadesMesConsulta
{
    public class GetActividadesMesAPPQuery : IRequest<string>
    {
        public int Mes { get; set; }
        public int Anho { get; set; }
        public int IdIdioma { get; set; }
    }
}