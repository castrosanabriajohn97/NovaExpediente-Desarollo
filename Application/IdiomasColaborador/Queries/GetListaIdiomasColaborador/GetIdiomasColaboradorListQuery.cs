// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.IdiomasColaborador.Queries.GetListaIdiomasColaborador
{
   public class GetIdiomasColaboradorListQuery : IRequest<IdiomaColaboradorListVm>
    {
        public int Id { get; set; }
    }
}





