// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.OneSignalAPP.Commands.SendNotification
{
    public class SendNotificationCommandValidator : AbstractValidator <SendNotificationCommand> 
    {
        public SendNotificationCommandValidator()
        {
            
        }
    }
}
