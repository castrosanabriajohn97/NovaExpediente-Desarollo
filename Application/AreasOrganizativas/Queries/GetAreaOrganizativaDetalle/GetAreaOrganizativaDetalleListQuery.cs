// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;


namespace NovaExpediente.Application.AreasOrganizativas.Queries.GetAreaOrganizativaDetalle
{
    public class GetAreaOrganizativaDetalleListQuery : IRequest<AreaOrganizativaDetalleVm>
    {
        public int Id { get; set; }
    }
}
