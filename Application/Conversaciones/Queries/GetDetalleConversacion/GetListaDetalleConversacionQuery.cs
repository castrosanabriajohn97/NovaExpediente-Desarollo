// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Conversaciones.Queries.GetDetalleConversacion
{
    public class GetListaDetalleConversacionQuery : IRequest<string>
    {
        public string conversationId { get; set; }
    }
}
