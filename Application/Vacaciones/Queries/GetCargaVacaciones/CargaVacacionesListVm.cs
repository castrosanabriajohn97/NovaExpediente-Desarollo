// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.Vacaciones.Queries.GetCargaVacaciones
{
    public class CargaVacacionesListVm
    {
        public IList<CargaVacacionesDto> Cargas { get; set; }

        public int count;
    }
}
