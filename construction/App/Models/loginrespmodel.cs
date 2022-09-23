namespace App.Models
{
    public class loginrespmodel
    {
        public string AccessToken { get; set; }
        public bool IsAdmin { get; set; }
        public string UserName { get; set; }
        public int? roleid { get; set; }
        public int userid { get; set; }
        public string error { get; set; }
    }
}
