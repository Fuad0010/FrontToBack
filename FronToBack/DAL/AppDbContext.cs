using FronToBack.Models;
using Microsoft.EntityFrameworkCore;
namespace FronToBack.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderContent> SliderContents { get; set; }
    }
}
