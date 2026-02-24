// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using AutoMapper;
using NovaExpediente.Application.Common.Mappings;
using NovaExpediente.Domain.Entities;
using System;

namespace NovaExpediente.Application.FormacionesAcademicas.Queries.GetListaFormacionAcademicaDocumento
{
    public class FormacionAcademicaDocumentoDto : IMapFrom<FormacionAcademica>
    {

        public string Certificado { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<FormacionAcademica, FormacionAcademicaDocumentoDto>()
                .ForMember(d => d.Certificado, opt => opt.MapFrom(s => s.CERTIFICADO != null ?
                                                                               string.Concat(s.MIMETYPE, Convert.ToBase64String(s.CERTIFICADO)) : ""));
        }
    }
}
