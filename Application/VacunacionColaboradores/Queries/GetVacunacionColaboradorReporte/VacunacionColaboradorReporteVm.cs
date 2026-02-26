// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.VacunacionColaboradores.Queries.GetVacunacionColaboradorReporte
{
    public class VacunacionColaboradorReporteVm
    {
        public List<VacunacionColaboradorReporteDto> VacunacionColaboradores { get; set; }
        public int Count { get; set; }
    }
}
