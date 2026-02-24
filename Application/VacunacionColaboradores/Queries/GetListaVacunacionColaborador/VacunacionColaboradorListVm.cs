// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.

using System.Collections.Generic;

namespace NovaExpediente.Application.VacunacionColaboradores.Queries.GetListaVacunacionColaborador
{
    public class VacunacionColaboradorListVm
    {
        public IList<VacunacionColaboradorDto> VacunacionColaboradores { get; set; }
        public int Count { get; set; }
    }
}