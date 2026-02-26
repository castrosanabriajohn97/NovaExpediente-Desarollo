// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Vacaciones.Queries.GetListaVacaciones
{
    public class GetVacacionesListQuery : IRequest<VacacionesVm>
    {
        public int IdColaborador { get; set; }
        public int IdSolicitudMasterData { get; set; }

    }
}
