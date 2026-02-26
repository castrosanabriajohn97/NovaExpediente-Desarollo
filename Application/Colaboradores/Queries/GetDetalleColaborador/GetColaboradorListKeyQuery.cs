// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Colaboradores.Queries.GetDetalleColaborador
{
   public class GetColaboradorListKeyQuery : IRequest<ColaboradorVm>
    {
        public int Id { get; set; }
    }
}





