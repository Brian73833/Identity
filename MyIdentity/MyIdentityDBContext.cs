using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity.MyIdentity;

public class MyIdentityDBContext : IdentityDbContext<MyUser, MyRol, string>
{
    public MyIdentityDBContext(DbContextOptions<MyIdentityDBContext> options) : base(options)
    {
    }
}
