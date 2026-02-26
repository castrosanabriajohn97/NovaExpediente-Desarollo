// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.UnosAUnos.Queries.GetListaUnosAUnos
{
    public class GetListaUnosAUnosQuery : IRequest<ListaUnosAUnosVm>
    {
        public int IdDeliveryManager { get; set; }
    }
}
