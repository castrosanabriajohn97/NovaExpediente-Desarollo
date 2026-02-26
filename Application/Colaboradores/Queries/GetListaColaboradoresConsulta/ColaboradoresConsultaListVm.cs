// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.Colaboradores.Queries.GetListaColaboradoresConsulta
{
    public class ColaboradoresConsultaListVm
    {
        public IList<ColaboradoresConsultaDto> Colaboradores { get; set; }


        public int Cantidad { get; set; }


    }
}
