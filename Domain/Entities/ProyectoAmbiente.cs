// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using NovaExpediente.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovaExpediente.Domain.Entities
{
    [Table("PROYECTOAMBIENTE", Schema = "NE")]
    public class ProyectoAmbiente : AuditableEntity
    {
        public ProyectoAmbiente()
        {

        }
        [Key]
        public int IDPROYECTOAMBIENTE { get; set; }
        public int IDPROYECTO { get; set; }
        public int IDAMBIENTEDESARROLLO { get; set; }
        




        [ForeignKey("IDPROYECTO")]
        public virtual Proyecto Proyecto { get; set; }

        [ForeignKey("IDAMBIENTEDESARROLLO")]
        public virtual AmbienteDesarrollo AmbienteDesarrollo { get; set; }



    }
}
