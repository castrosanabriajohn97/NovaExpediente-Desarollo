// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace NovaExpediente.Application.Common.Interfaces
{
    public interface IOneSignalService
    {

        Task<string> ViewDevices();
        Task<string> ViewNotifications();
        Task<string> DeleteDevice(string Id);
        Task<string> SendNotification(string titulo,string msj,string[] segmentos, string todos);
    }
}
