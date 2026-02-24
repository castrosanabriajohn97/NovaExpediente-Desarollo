// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.AplicacionMovil.Convenios.Queries.GetDetalleConvenio
{
    public class GetDetalleConvenioQuery : IRequest<string>
    {
        public int IdConvenio{ get; set; }
    }
}
