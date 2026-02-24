// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.Clientes.Queries.GetListaClienteReferencias
{
    public class ClienteReferenciasListVm
    {
        public IList<ClienteReferenciasDto> ClientesReferencias { get; set; }

        public int Count { get; set; }
    }
}
