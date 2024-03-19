using Microsoft.AspNetCore.Identity;

namespace Blogy.EntityLayer.Concrete
{
    public class AppRole : IdentityRole<int>
    {  
        public string Description { get; set; }
    }
}
