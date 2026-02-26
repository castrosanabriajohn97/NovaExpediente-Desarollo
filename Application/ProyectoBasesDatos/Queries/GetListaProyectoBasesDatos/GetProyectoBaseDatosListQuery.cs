// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ProyectoBasesDatos.Queries.GetListaProyectoBaseDatos
{
   public class GetProyectoBaseDatosListQuery : IRequest<ProyectoBaseDatosListVm>
    {
        public int Id { get; set; }
    }
}





