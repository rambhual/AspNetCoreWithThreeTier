﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DniFruitsKart.UI.AdventureWorks
{
    [Table("ContactType", Schema = "Person")]
    public partial class ContactType
    {
        public ContactType()
        {
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
        }

        [Column("ContactTypeID")]
        public int ContactTypeId { get; set; }
        [Required]
        [Column(TypeName = "Name")]
        public string Name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("ContactType")]
        public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
    }
}
