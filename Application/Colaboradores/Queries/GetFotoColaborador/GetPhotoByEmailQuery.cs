// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Colaboradores.Queries.GetFotoColaborador
{
   public class GetPhotoByEmailQuery : IRequest<FotoColaboradorVm>
    {
        public string Email { get; set; }
    }
}





