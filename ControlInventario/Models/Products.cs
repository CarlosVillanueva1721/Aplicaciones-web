using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlInventario.Models
{
    public class Products 
    {
        public int Id { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int SupplirId { get; set; }
        [ForeignKey("SupplirId")]
        public Supplier Supplier { get; set; }


    }
}