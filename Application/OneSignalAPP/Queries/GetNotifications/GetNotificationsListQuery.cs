// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.OneSignalAPP.Queries.GetNotifications
{
    public class GetNotificationsListQuery : IRequest<string>
    {
        public string cliente { get; set; }
    }
}
