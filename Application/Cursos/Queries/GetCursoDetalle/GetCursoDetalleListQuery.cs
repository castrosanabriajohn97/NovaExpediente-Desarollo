// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Cursos.Queries.GetCursoDetalle
{
    public class GetCursoDetalleListQuery : IRequest<CursoDetalleVm>
    {
        public int Id { get; set; }
    }
}
