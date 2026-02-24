// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovaExpediente.Application.Common.Interfaces
{
    public interface ICurrentUserService
    {
        int UserId { get; }

        bool IsAuthenticated { get; }

        List<string> GetRoles();
        Task<List<string>> GetPermissions();
    }
}
