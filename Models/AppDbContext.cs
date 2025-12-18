using System;
using Microsoft.EntityFrameworkCore;

namespace mvctest.Models;

public class AppDbContext :DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
    {
        
    }
}
