// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Afiliacion.Queries.GetListaAfiliacion
{
   public class GetAfiliacionListQuery : IRequest<AfiliacionListVm>
    {
        public int Id { get; set; }
    }
}





