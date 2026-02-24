// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.

using System.Collections.Generic;

namespace NovaExpediente.Application.VacunasColaboradores.Queries.GetListaVacunasColaborador
{
    public class VacunasColaboradorListVm
    {
        public IList<VacunasColaboradorDto> VacunasColaborador { get; set; }
        public int Count { get; set; }
    }
}