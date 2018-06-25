using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Memberships.Models
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(255)]
        [Required]
        public String Title { get; set; }

        [MaxLength(2048)]
        public String Description { get; set; }

        [MaxLength(1024)]
        public String ImageUrl { get; set; }

        public int ProductLinkTextId { get; set; }

        public int ProductTypeId { get; set; }


    }
}