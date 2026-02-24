// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;
using NovaExpediente.Application.Common.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace NovaExpediente.Application.AplicacionMovil.Convenios.Queries.GetDetalleConvenio
{
    public class GetDetalleConvenioQueryHandler : IRequestHandler<GetDetalleConvenioQuery, string>
    {
        private readonly INovaExpedienteDbContext _context;
        public GetDetalleConvenioQueryHandler(INovaExpedienteDbContext context)
        {
            _context = context;
        }
        public async Task<string> Handle(GetDetalleConvenioQuery request, CancellationToken cancellationToken)
        {
            var list = await _context.ConsultaDetalleConvenio(request.IdConvenio);
            return list;
        }
    }
}
