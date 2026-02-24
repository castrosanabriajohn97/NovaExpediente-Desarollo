// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using NovaExpediente.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NovaExpediente.Domain.Entities
{
    [Table("EXPERIENCIABASEDATOS", Schema = "NE")]
    public class ExperienciaBaseDatos : AuditableEntity
    {
        public ExperienciaBaseDatos()
        {

        }
        [Key]
        public int IDCOLABORADOR { get; set; }
        public int IDBASEDATOS { get; set; }
        public int IDNIVELCONOCIMIENTO { get; set; }
        public int MESESEXPERIENCIA { get; set; }



        [ForeignKey("IDBASEDATOS")]
        public virtual BaseDatos BaseDatos { get; set; }

        [ForeignKey("IDNIVELCONOCIMIENTO")]
        public virtual NivelConocimiento NivelConocimiento { get; set; }



    }
}
