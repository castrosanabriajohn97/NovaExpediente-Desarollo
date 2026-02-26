// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;
using NovaExpediente.Application.Common.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace NovaExpediente.Application.Actividades.Queries.GetActividadesDiaConsulta
{
    public class GetActividadesDiaAPPQueryHandler : IRequestHandler<GetActividadesDiaAPPQuery, string>
    {
        private readonly INovaExpedienteDbContext _context;

        public GetActividadesDiaAPPQueryHandler(INovaExpedienteDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(GetActividadesDiaAPPQuery request, CancellationToken cancellationToken)
        {
            var lista = await _context.ConsultaActividadesDiaAPP(request.Fecha, request.IdIdioma);
            return lista;
        }

    }
}