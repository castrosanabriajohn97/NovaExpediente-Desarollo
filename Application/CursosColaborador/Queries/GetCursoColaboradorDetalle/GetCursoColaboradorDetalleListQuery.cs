// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.CursosColaborador.Queries.GetCursoColaboradorDetalle
{
   public class GetCursoColaboradorDetalleListQuery : IRequest<CursoColaboradorDetalleVm>
    {
        public int Id { get; set; }
    }
}





