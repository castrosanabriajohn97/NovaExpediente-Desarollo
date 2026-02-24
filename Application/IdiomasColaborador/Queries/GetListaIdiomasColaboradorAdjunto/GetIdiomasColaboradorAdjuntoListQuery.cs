// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.IdiomasColaborador.Queries.GetListaIdiomasColaboradorAdjunto
{
   public class GetIdiomasColaboradorAdjuntoListQuery : IRequest<IdiomaColaboradorAdjuntoListVm>
    {
        public int Id { get; set; }
    }
}





