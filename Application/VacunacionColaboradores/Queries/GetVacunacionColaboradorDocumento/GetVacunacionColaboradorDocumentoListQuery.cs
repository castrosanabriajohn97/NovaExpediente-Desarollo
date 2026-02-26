// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.VacunacionColaboradores.Queries.GetVacunacionColaboradorDocumento
{
   public class GetVacunacionColaboradorDocumentoListQuery : IRequest<VacunacionColaboradorDocumentoVm>
    {
        public int IdColaborador { get; set; }
    }
}





