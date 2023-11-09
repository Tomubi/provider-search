using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Providers.Any()) return;

            var providers = new List<Provider>
            {
                new Provider
                {
                    Name = "Emily Stanton",
                    Specialty = "Internal Medicine",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    DateDescription = "Joined 2 months ago",
                    City = "Springfield"
                },
                new Provider
                {
                    Name = "Aiden Burke",
                    Specialty = "Family Medicine",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    DateDescription = "Joined last month",
                    City = "Fairview"
                },
                new Provider
                {
                    Name = "Nora Kaplan",
                    Specialty = "Pulmonary Disease",
                    Date = DateTime.UtcNow.AddMonths(1),
                    DateDescription = "Starting in a month",
                    City = "Ridgemont"
                },
                new Provider
                {
                    Name = "Lucas Werner",
                    Specialty = "Osteopathic Medicine",
                    Date = DateTime.UtcNow.AddMonths(2),
                    DateDescription = "Starting in 2 months",
                    City = "Oakdale"
                },
                new Provider
                {
                    Name = "Grace Tam",
                    Specialty = "Internal Medicine",
                    Date = DateTime.UtcNow.AddMonths(3),
                    DateDescription = "Starting in 3 months",
                    City = "Brookside"
                },
                new Provider
                {
                    Name = "Ethan Lloyd",
                    Specialty = "Family Medicine",
                    Date = DateTime.UtcNow.AddMonths(4),
                    DateDescription = "Starting in 4 months",
                    City = "Cedarwood"
                },
                new Provider
                {
                    Name = "Mia Clarkson",
                    Specialty = "Pulmonary Disease",
                    Date = DateTime.UtcNow.AddMonths(5),
                    DateDescription = "Starting in 5 months",
                    City = "Pinecrest"
                },
                new Provider
                {
                    Name = "Oliver Thorne",
                    Specialty = "Osteopathic Medicine",
                    Date = DateTime.UtcNow.AddMonths(6),
                    DateDescription = "Starting in half a year",
                    City = "Maple Grove"
                },
                new Provider
                {
                    Name = "Ava Whitlock",
                    Specialty = "Internal Medicine",
                    Date = DateTime.UtcNow.AddMonths(7),
                    DateDescription = "Starting in 7 months",
                    City = "Elmwood"
                },
                new Provider
                {
                    Name = "Noah Ramsey",
                    Specialty = "Family Medicine",
                    Date = DateTime.UtcNow.AddMonths(8),
                    DateDescription = "Starting in 8 months",
                    City = "Roseville"
                }
            };

            await context.Providers.AddRangeAsync(providers);
            await context.SaveChangesAsync();
        }
    }
}