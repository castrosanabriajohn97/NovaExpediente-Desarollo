// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovaExpediente.Application.Common.Interfaces
{
    public interface ISecurityService
    {

        Task<List<string>> GetUsersWithRole(string roleName);
    }
}
