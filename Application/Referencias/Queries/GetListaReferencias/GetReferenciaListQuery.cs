// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Referencias.Queries.GetListaReferencias
{
   public class GetReferenciaListQuery : IRequest<ReferenciaListVm>
    {
        public int Id { get; set; }
    }
}





