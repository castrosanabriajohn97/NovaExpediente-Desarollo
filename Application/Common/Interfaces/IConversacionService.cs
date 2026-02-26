// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Threading.Tasks;

namespace NovaExpediente.Application.Common.Interfaces
{
    public interface IConversacionService
    {
        Task<string> ConsultaConversaciones(string userId, int currentPage);
        Task<string> ConsultaConversacionDetalle(string conversationId);
        Task<string> CrearConversacion(string userId);
        Task<string> CrearMensaje(string userId, string conversationId, string message);
    }
}
