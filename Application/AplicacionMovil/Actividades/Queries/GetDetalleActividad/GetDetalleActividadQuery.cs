// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.AplicacionMovil.Actividades.Queries.GetDetalleActividad
{
    public class GetDetalleActividadQuery : IRequest<string>
    {
        public int IdActividad { get; set; }
    }
}
