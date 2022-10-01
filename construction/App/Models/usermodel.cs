using App.Entity;
using System.Collections.Generic;

namespace App.Models
{
    public class usermodel
    {
        public int tabid { get; set; }

        public int roleid { get; set; }
        public string rolename { get; set; }
        public List<tbl_role> rolelist { get; set; }
    }
}
