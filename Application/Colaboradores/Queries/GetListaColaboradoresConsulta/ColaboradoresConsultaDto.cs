// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿namespace NovaExpediente.Application.Colaboradores.Queries.GetListaColaboradoresConsulta
{
    public class ColaboradoresConsultaDto
    {
        public int IDCOLABORADOR { get; set; }
        public string IDENTIFICACION { get; set; }
        public string NOMBRECOMPLETO { get; set; }
        public string DELIVERYMANAGER { get; set; }
        public decimal RANKING { get; set; }

    }
}
