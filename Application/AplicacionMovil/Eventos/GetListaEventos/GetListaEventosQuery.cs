// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;
using Newtonsoft.Json.Linq;

namespace NovaExpediente.Application.AplicacionMovil.Eventos.GetListaEventos
{
    public  class GetListaEventosQuery : IRequest<JObject>
    {
    }
}
