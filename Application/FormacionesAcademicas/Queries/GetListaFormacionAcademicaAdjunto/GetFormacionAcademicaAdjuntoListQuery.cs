// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.FormacionesAcademicas.Queries.GetListaFormacionAcademicaAdjunto
{
   public class GetFormacionAcademicaAdjuntoListQuery : IRequest<FormacionAcademicaAdjuntoListVm>
    {
        public int Id { get; set; }
    }
}





