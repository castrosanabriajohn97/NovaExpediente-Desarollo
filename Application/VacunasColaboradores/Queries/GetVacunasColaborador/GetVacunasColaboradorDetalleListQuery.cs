// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.

 using MediatR;

namespace NovaExpediente.Application.VacunasColaboradores.Queries.GetVacunasColaboradorDetalle
{
    public class GetVacunasColaboradorDetalleListQuery : IRequest<VacunasColaboradorDetalleVm>
    {
        public long IdVacunasColaborador { get; set; }
    }
}