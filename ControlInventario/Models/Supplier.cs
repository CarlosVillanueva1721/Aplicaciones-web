using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ControlInventario.Models
{
    public class Supplier
    {
        public int Id { get; set; }
       
        public int SupplierCode { get; set; }
        [Display(Name = "Codigo Proveedor")]
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}