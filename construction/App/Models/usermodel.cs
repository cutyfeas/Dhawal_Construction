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

        public int pageid { get; set; }
        public string pagename { get; set; }
        public List<tbl_pages> pagelist { get; set; }

        public int rolepageid { get; set; }
        public List<tbl_role_page> rolepagelist { get; set; }

    }
}
