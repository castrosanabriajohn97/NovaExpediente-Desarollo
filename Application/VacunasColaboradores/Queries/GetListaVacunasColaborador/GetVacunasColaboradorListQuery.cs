// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.

using MediatR;
using System;

namespace NovaExpediente.Application.VacunasColaboradores.Queries.GetListaVacunasColaborador
{
    public class GetVacunasColaboradorListQuery : IRequest<VacunasColaboradorListVm>
    {
        public int IdColaborador { get; set; }

    }
}