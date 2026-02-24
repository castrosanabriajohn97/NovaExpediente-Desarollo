// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;
using NovaExpediente.Application.Common.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace NovaExpediente.Application.OneSignalAPP.Commands.DeleteDevice
{
    public class DeleteDeviceCommand : IRequest<string>
    {

        public string Id_Player { get; set; }

        public class DeleteDeviceCommandHandler : IRequestHandler<DeleteDeviceCommand, string>
        {

            private readonly IOneSignalService _service;
            public DeleteDeviceCommandHandler(IOneSignalService service)
            {

                _service = service;
            }

            public async Task<string> Handle(DeleteDeviceCommand request, CancellationToken cancellationToken)
            {


                string res = await _service.DeleteDevice(request.Id_Player);


                return res;

            }
        }


    }
}
