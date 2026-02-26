// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;
using NovaExpediente.Application.AplicacionMovil.Convenios.Queries.GetDetalleConvenio;
using NovaExpediente.Application.Common.Interfaces;
using System.Threading.Tasks;
using System.Threading;

namespace NovaExpediente.Application.UnosAUnos.Queries.GetDetalleUnoAUno
{
    public class GetDetalleUnoAUnoQueryHandler : IRequestHandler<GetDetalleUnoAUnoQuery, string>
    {
        private readonly INovaExpedienteDbContext _context;
        public GetDetalleUnoAUnoQueryHandler(INovaExpedienteDbContext context)
        {
            _context = context;
        }
        public async Task<string> Handle(GetDetalleUnoAUnoQuery request, CancellationToken cancellationToken)
        {
            var list = await _context.ConsultaDetalleUnoaUno(request.IdUnoAUno);
            return list;
        }
    }
}

