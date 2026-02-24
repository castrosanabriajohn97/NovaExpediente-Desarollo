// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.FormacionesAcademicas.Queries.GetListaFormacionAcademicaDetalle
{
   public class GetFormacionAcademicaDetalleListQuery : IRequest<FormacionAcademicaDetalleVm>
    {
        public int Id { get; set; }
    }
}





