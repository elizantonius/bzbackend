namespace bzbackend.Data
{
    public class DbContext
    {
        private DbContextOptions<DataContext> options;

        public DbContext(DbContextOptions<DataContext> options)
        {
            this.options = options;
        }
    }
}