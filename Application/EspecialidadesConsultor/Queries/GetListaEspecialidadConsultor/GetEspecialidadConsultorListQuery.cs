// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.EspecialidadesConsultor.Queries.GetListaEspecialidadConsultor
{
   public class GetEspecialidadConsultorListQuery : IRequest<EspecialidadConsultorListVm>
    {
        public int Id { get; set; }
    }
}





