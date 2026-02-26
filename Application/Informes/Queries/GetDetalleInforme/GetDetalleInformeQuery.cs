// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
using MediatR;
namespace NovaExpediente.Application.Informes.Queries.GetDetalleInforme
{
    public class GetDetalleInformeQuery : IRequest<string>
    {
        public string  ConversationId { get; set; }
    }
}
