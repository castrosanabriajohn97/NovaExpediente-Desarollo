// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.LenguajesProgramacion.Queries.GetLenguajeProgramacionDetalle
{
    public class GetLenguajeProgramacionDetalleListQuery : IRequest<LenguajeProgramacionDetalleVm>
    {
        public int Id { get; set; }
    }
}





