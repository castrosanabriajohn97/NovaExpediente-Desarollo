// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.FormacionesAcademicas.Queries.GetListaFormacionAcademicaDocumento
{
   public class GetFormacionAcademicaDocumentoByIdQuery : IRequest<FormacionAcademicaDocumentoVm>
    {
        public int Id { get; set; }
    }
}





