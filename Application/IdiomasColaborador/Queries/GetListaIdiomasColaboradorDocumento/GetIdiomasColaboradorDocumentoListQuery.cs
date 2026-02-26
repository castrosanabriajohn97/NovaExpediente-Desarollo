// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.IdiomasColaborador.Queries.GetListaIdiomasColaboradorDocumento
{
   public class GetIdiomasColaboradorDocumentoListQuery : IRequest<IdiomaColaboradorDocumentoVm>
    {
        public string Id { get; set; }
    }
}





