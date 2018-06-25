using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Mvc;

namespace Memberships.Models
{
    public class Item
    {
        public int Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Title { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }

        [MaxLength(1024)]
        public string Url { get; set; }

        [MaxLength(1024)]
        public string ImageUrl { get; set; }

        [AllowHtml]
        public string HTML { get; set; }

        [DefaultValue(0)]
        public int WaitDays { get; set; }

        public string HTMLShort
        {
            get { return HTML == null || HTML.Length <= 50 ? HTML : HTML.Substring(0, 50);}
         
        }

        public int ProductId { get; set; }

        public int ItemTypeId { get; set; }

        public int SectionId { get; set; }

        public int PartId { get; set; }

        public int IsFree { get; set; }

        [DisplayName("Item Type")]
        public ICollection<ItemType> ItemTypes { get; set; }

        [DisplayName("Section")]
        public ICollection<Section> Sections { get; set; }

        [DisplayName("Parts")]
        public ICollection<Part> Parts  { get; set; }


    }
}