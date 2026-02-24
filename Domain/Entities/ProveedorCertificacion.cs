// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using NovaExpediente.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovaExpediente.Domain.Entities
{
    [Table("PROVEEDORCERTIFICACION", Schema = "NE")]
    public class ProveedorCertificacion : AuditableEntity
    {
        public ProveedorCertificacion()
        {

        }
        [Key]
        public int IDPROVEEDORCERTIFICACION { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }


      
        public virtual ICollection<CertificacionProveedor> ProveedorCertificaciones { get; set; }

    }
}
