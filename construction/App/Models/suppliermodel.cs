using App.Entity;
using System.Collections.Generic;

namespace App.Models
{
    public class suppliermodel
{
        public suppliermodel()
        {
            this.mastertype = new tbl_mastertype();
            this.mastertypelist = new List<tbl_mastertype>();

            this.masterfield = new tbl_masterfields();
            this.masterfieldlist = new List<tbl_masterfields>();

            this.mastertypefield = new tbl_mastertypefields();
            this.mastertypefieldlist = new List<tbl_mastertypefields>();

            this.supplier = new tbl_suppliers();
            this.supplierlist = new List<tbl_suppliers>();

            this.mastertypesupplier = new tbl_mastertype_supplier_map();
            this.mastertypesupplierlist = new List<tbl_mastertype_supplier_map>();
        }
        public int tabid { get; set; }

        public tbl_mastertype mastertype { get; set; }
        public List<tbl_mastertype> mastertypelist { get; set; }

        public tbl_masterfields masterfield { get; set; }
        public List<tbl_masterfields> masterfieldlist { get; set; }

        public tbl_mastertypefields mastertypefield { get; set; }
        public List<tbl_mastertypefields> mastertypefieldlist { get; set; }

        public tbl_suppliers supplier { get; set; }
        public List<tbl_suppliers> supplierlist { get; set; }

        public tbl_mastertype_supplier_map mastertypesupplier { get; set; }
        public List<tbl_mastertype_supplier_map> mastertypesupplierlist { get; set; }

    }
}
