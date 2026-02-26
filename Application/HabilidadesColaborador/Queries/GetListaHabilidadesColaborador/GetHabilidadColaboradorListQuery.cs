// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.HabilidadesColaborador.Queries.GetListaHabilidadesColaborador
{
   public class GetHabilidadColaboradorListQuery : IRequest<HabilidadColaboradorListVm>
    {
        public int Id { get; set; }
    }
}





