// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.ExperienciasBaseDatos.Queries.GetCantidadColabradoresPorBaseDatos
{
    public class ColaboradoresBaseDatosVm
    {

        public IList<ColaboradoresBaseDatosDto> Colaboradores { get; set; }    

        public int Cantidad { get; set; }
    }
}
