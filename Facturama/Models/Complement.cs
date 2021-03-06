﻿using System.Collections.Generic;
using Facturama.Models.Complements;
using Facturama.Models.Complements.Payroll;
using Facturama.Models.Response;
using Newtonsoft.Json;

namespace Facturama.Models
{
    public class Complement
    {
        [JsonProperty("TaxStamp")]
        public TaxStamp TaxStamp { get; set; }

        [JsonProperty("Payments")]
        public List<Payment> Payments { get; set; }
		
	    [JsonProperty("Payroll")]
	    public Payroll Payroll { get; set; }
	}
}


