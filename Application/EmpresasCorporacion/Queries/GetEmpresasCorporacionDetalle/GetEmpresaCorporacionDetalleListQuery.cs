// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.EmpresasCorporacion.Queries.GetEmpresasCorporacionDetalle
{
    public class GetEmpresaCorporacionDetalleListQuery : IRequest<EmpresaCorporacionDetalleVm>
    {
        public int Id { get; set; }
    }
}





