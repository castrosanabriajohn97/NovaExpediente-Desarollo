// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using NovaExpediente.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovaExpediente.Domain.Entities
{
    [Table("IMAGEN", Schema = "NE")]
    public class Imagen : AuditableEntity
    {
        public Imagen() { }

        [Key]
        public int IDIMAGEN { get; set; }

        [Required]
        public string URLIMAGEN { get; set; }
    }
}
