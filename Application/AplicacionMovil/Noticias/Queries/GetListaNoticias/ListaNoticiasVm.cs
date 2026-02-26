// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.AplicacionMovil.Noticias.Queries.GetListaNoticias
{
    public class ListaNoticiasVm
    {
        public IList<NoticiaDto> Noticias { get; set; }
        public int count;
    }
}
