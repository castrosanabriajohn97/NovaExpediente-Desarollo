// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;
using NovaExpediente.Application.Common.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace NovaExpediente.Application.AplicacionMovil.Sorteos.Queries.GetDetalleSorteo
{
    public class GetDetalleSorteoQueryHandler : IRequestHandler<GetDetalleSorteoQuery, string>
    {
        private readonly INovaExpedienteDbContext _context;
        public GetDetalleSorteoQueryHandler(INovaExpedienteDbContext context)
        {
            _context = context;
        }
        public async Task<string> Handle(GetDetalleSorteoQuery request, CancellationToken cancellationToken)
        {
            var list = await _context.ConsultaDetalleSorteo(request.IdSorteo);
            return list;
        }
    }
}
