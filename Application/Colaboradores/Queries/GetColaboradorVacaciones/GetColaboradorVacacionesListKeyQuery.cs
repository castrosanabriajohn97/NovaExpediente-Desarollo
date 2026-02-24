// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Colaboradores.Queries.GetColaboradorVacaciones
{
   public class GetColaboradorVacacionesListKeyQuery : IRequest<ColaboradorVacacionesVm>
    {
        public int Id { get; set; }
    }
}





