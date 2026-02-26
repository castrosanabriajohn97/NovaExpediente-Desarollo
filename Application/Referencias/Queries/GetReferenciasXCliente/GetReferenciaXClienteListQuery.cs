// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Referencias.Queries.GetReferenciasXCliente
{
   public class GetReferenciaXClienteListQuery : IRequest<ReferenciaXClienteListVm>
    {
        public int Id { get; set; }
    }
}





