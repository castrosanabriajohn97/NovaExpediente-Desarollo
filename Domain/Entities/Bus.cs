// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using NovaExpediente.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovaExpediente.Domain.Entities
{
    [Table("BUS", Schema = "NE")]
    public class Bus : AuditableEntity
    {
        public Bus()
        {

        }
        [Key]
        public int IdBus { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }





    }
}
