﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Memberships.Models
{
    public class Section
    {
        public int Id { get; set; }
        [Required]
        public String Title { get; set; }
    }
}