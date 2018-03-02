﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Job_Tracker2.Models
{
    public class Company
    {
    [Key]
    public int CompanyId { get; set; }

    [Required]
    public string Name { get; set; }
    
    }
}
