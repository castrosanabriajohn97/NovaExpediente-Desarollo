// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.MasterData.Queries.GetVacacionesPorPerfil
{
    public class VacacionesPorPerfilVm
    {
        public IList<VacacionPerfilDto> Vacaciones { get; set; }
        public int Count { get; set; }
    }
}
