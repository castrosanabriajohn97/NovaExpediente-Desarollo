// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ErpCores.Queries.GetErpCoreDetalle
{
   public class GetErpCoreDetalleListQuery : IRequest<ErpCoreDetalleVm>
    {
       public int Id { get; set; }
    }
}





