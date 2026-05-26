using Microsoft.AspNetCore.Identity;

namespace Identity.MyIdentity;

public class MyRol : IdentityRole
{
    public string Seccion { get; set; } = string.Empty;
    public DateTime FechaAlta { get; set; }
}