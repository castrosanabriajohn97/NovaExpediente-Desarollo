// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.ExperienciasBaseDatos.Queries.GetCantidadColabradoresPorBaseDatos
{
   public class ColaboradoresBaseDatosListVm
    {
        public IList<ColaboradoresBaseDatosDto> colaboradores { get; set; }

        public int cantidad { get; set; }
    }
}
