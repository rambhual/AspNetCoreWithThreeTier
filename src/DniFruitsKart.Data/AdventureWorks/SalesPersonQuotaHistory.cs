﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DniFruitsKart.Data.AdventureWorks
{
    [Table("SalesPersonQuotaHistory", Schema = "Sales")]
    public partial class SalesPersonQuotaHistory
    {
        [Column("BusinessEntityID")]
        public int BusinessEntityId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime QuotaDate { get; set; }
        [Column(TypeName = "money")]
        public decimal SalesQuota { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("BusinessEntityId")]
        [InverseProperty("SalesPersonQuotaHistory")]
        public virtual SalesPerson BusinessEntity { get; set; }
    }
}
