// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using NovaExpediente.Application.Notifications.Models;
using System.Threading.Tasks;

namespace NovaExpediente.Application.Common.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(MessageDto message);
        Task SendAsync(MensajeSolicitudAdministrativa message);
    }
}
