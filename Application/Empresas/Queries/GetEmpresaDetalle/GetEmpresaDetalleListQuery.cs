// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Empresas.Queries.GetEmpresaDetalle
{
    public class GetEmpresaDetalleListQuery : IRequest<EmpresaDetalleVm>
    {
        public int Id { get; set; }
    }
}





