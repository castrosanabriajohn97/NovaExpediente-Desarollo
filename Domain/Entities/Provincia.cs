// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using NovaExpediente.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovaExpediente.Domain.Entities
{
	[Table("PROVINCIA", Schema = "NE")]
	public class Provincia : AuditableEntity
	{
		public Provincia()
		{

		}
		[Key]
		public int IDPROVINCIA { get; set; }

		public string NOMBRE { get; set; }

	}
}