// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.

 using MediatR;

namespace NovaExpediente.Application.VacunacionColaboradores.Queries.GetVacunacionColaboradorDetalle
{
    public class GetVacunacionColaboradorDetalleListQuery : IRequest<VacunacionColaboradorDetalleVm>
    {
        public long IdColaborador { get; set; }
    }
}