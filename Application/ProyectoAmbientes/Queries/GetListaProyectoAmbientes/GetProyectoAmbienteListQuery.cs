// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ProyectoAmbientes.Queries.GetListaProyectoAmbientes
{
   public class GetProyectoAmbienteListQuery : IRequest<ProyectoAmbienteListVm>
    {
        public int Id { get; set; }
    }
}





