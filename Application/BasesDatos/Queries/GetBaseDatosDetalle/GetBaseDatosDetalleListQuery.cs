// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.BasesDatos.Queries.GetBaseDatosDetalle
{
   public class GetBaseDatosDetalleListQuery : IRequest<BaseDatosDetalleVm>
    {
       public int Id { get; set; }
    }
}





