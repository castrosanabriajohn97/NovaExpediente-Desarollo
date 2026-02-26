// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaExpediente.Application.Clientes.Queries.GetCantidadClientes
{
    public class CantidadClientesVm
    {
        public int TotalClientes { get; set; }
        public int ClientesActivos { get; set; }
    }
}
