﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Job_Tracker2.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        public string Name { get; set; }

        [Required]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
