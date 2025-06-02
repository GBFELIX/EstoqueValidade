using Microsoft.AspNetCore.Identity;

namespace InventarioValidade.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Login { get; set; }
        
        public string Senha { get; set; }
    }
}
