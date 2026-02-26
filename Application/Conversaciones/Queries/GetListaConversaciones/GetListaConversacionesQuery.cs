// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Conversaciones.Queries.GetListaConversaciones
{
    public class GetListaConversacionesQuery : IRequest<string>
    {
        public string userId { get; set; }
        public int currentPage { get; set; }
    }
}
