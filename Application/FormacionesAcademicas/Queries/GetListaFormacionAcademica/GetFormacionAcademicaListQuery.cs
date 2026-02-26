// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.FormacionesAcademicas.Queries.GetListaFormacionAcademica
{
   public class GetFormacionAcademicaListQuery : IRequest<FormacionAcademicaListVm>
    {
        public int Id { get; set; }
    }
}





