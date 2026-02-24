// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.CursosImpartir.Queries.GetListaCursosImpartir
{
   public class GetCursoImpartirListQuery : IRequest<CursoImpartirListVm>
    {
        public int Id { get; set; }
    }
}





