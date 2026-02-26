// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
using System;
using NovaExpediente.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovaExpediente.Domain.Entities
{
    [Table("VACUNA", Schema = "NE")]
    public class Vacuna : AuditableEntity
    {
        public Vacuna()
        {

        }
        [Key]
        public int IdVacuna { get; set; }

        public string Nombre { get; set; }
    }
}
