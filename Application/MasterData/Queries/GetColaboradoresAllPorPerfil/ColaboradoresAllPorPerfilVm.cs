// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.MasterData.Queries.GetColaboradoresAllPorPerfil
{
    public class ColaboradoresAllPorPerfilVm
    {
        public IList<ColaboradorAllPerfilDto> Colaboradores { get; set; }
        public int Count { get; set; }
    }
}
