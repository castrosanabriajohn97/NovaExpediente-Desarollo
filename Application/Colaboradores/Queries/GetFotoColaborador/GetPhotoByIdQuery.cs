// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Colaboradores.Queries.GetFotoColaborador
{
   public class GetPhotoByIdQuery : IRequest<FotoColaboradorVm>
    {
        public int Id { get; set; }
    }
}





