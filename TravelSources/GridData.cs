﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Several classes made to avoid unnecessary fields being displayed in DataGridViews
namespace GridData
{
    // still trying to think of a consistent, "sensical" naming convention for these classes... - Lance

    public partial class ProductNameID
    {
        public int ProductId { get; set; }
        public string ProdName { get; set; } = null!;
    }
    public partial class SupplierNameID
    {
        public int SupplierId { get; set; }
        public string SupName { get; set; } = null!;
    }
    public partial class ProdSuppIDs
    {
        public int ProductSupplierId { get; set; }
        public int? ProductId { get; set; }
        public int? SupplierId { get; set; }
    }

    public partial class PackageData
    {
        public int PackageId { get; set; }
        public string PkgName { get; set; } = null!;
        public DateTime? PkgStartDate { get; set; }
        public DateTime? PkgEndDate { get; set; }
        public string? PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal? PkgAgencyCommission { get; set; }
    }


    // Custom class to display Product/Supplier Names for the Packages Add/Modify Form - By: Lance Salvador
    public partial class ProdSuppNames
    {
        public string? ProdName { get; set; }
        public string? SuppName { get; set; }

    }
    
}
