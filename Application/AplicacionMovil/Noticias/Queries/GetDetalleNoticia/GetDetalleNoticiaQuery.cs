// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.AplicacionMovil.Noticias.Queries.GetDetalleNoticia
{
    public class GetDetalleNoticiaQuery: IRequest<string>
    {
        public int IdNoticia { get; set; }
    }
}
