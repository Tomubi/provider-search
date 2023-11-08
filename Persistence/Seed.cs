using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Physicians.Any()) return;

            var physicians = new List<Physician>
            {
                new Physician
                {
                    Name = "Emily Stanton",
                    Specialty = "Internal Medicine",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    DateDescription = "Joined 2 months ago",
                    City = "Springfield"
                },
                new Physician
                {
                    Name = "Aiden Burke",
                    Specialty = "Family Medicine",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    DateDescription = "Joined last month",
                    City = "Fairview"
                },
                new Physician
                {
                    Name = "Nora Kaplan",
                    Specialty = "Pulmonary Disease",
                    Date = DateTime.UtcNow.AddMonths(1),
                    DateDescription = "Starting in a month",
                    City = "Ridgemont"
                },
                new Physician
                {
                    Name = "Lucas Werner",
                    Specialty = "Osteopathic Medicine",
                    Date = DateTime.UtcNow.AddMonths(2),
                    DateDescription = "Starting in 2 months",
                    City = "Oakdale"
                },
                new Physician
                {
                    Name = "Grace Tam",
                    Specialty = "Internal Medicine",
                    Date = DateTime.UtcNow.AddMonths(3),
                    DateDescription = "Starting in 3 months",
                    City = "Brookside"
                },
                new Physician
                {
                    Name = "Ethan Lloyd",
                    Specialty = "Family Medicine",
                    Date = DateTime.UtcNow.AddMonths(4),
                    DateDescription = "Starting in 4 months",
                    City = "Cedarwood"
                },
                new Physician
                {
                    Name = "Mia Clarkson",
                    Specialty = "Pulmonary Disease",
                    Date = DateTime.UtcNow.AddMonths(5),
                    DateDescription = "Starting in 5 months",
                    City = "Pinecrest"
                },
                new Physician
                {
                    Name = "Oliver Thorne",
                    Specialty = "Osteopathic Medicine",
                    Date = DateTime.UtcNow.AddMonths(6),
                    DateDescription = "Starting in half a year",
                    City = "Maple Grove"
                },
                new Physician
                {
                    Name = "Ava Whitlock",
                    Specialty = "Internal Medicine",
                    Date = DateTime.UtcNow.AddMonths(7),
                    DateDescription = "Starting in 7 months",
                    City = "Elmwood"
                },
                new Physician
                {
                    Name = "Noah Ramsey",
                    Specialty = "Family Medicine",
                    Date = DateTime.UtcNow.AddMonths(8),
                    DateDescription = "Starting in 8 months",
                    City = "Roseville"
                }
            };

            await context.Physicians.AddRangeAsync(physicians);
            await context.SaveChangesAsync();
        }
    }
}