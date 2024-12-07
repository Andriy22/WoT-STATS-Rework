namespace wot_stats.Persistence;

public class DbInitializer
{
    public static void Initialize(DataContext context)
    {
        context.Database.EnsureCreated();
    }
}
