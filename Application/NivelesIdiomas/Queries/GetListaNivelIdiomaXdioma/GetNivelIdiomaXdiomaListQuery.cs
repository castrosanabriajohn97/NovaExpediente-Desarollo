// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.NivelesIdiomas.Queries.GetListaNivelIdiomaXdioma
{
   public class GetNivelIdiomaXdiomaListQuery : IRequest<NivelIdiomaXdiomaListVm>
    {
        public int Id { get; set; }

    }
}





