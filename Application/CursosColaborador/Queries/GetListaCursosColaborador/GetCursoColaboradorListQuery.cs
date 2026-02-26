// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.CursosColaborador.Queries.GetListaCursosColaborador
{
   public class GetCursoColaboradorListQuery : IRequest<CursoColaboradorListVm>
    {
        public int Id { get; set; }
    }
}





