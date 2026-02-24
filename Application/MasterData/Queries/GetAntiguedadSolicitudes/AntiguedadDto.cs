// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaExpediente.Application.MasterData.Queries.GetAntiguedadSolicitudes
{
    public class AntiguedadDto
    {
        public string Tipo { get; set; }
        public decimal Cantidad { get; set; }
        public string Color { get; set; }
    }
}
