using Microsoft.EntityFrameworkCore;

namespace VeterianriaBackApi.Data
{
    public class Mapeo : DbContext
    {
        public Mapeo(DbContextOptions<Mapeo> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        }


    }
}
