// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.

 using MediatR;

namespace NovaExpediente.Application.Vacunas.Queries.GetVacunaDetalle
{
    public class GetVacunaDetalleListQuery : IRequest<VacunaDetalleVm>
    {
        public long IdVacuna { get; set; }
    }
}