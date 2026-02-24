// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Distritos.Queries.GetDistritoDetalle
{
    public class GetDistritoDetalleListQuery : IRequest<DistritoDetalleVm>
    {
       public int Id { get; set; }
    }
}





