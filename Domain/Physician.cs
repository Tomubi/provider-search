namespace Domain
{
    public class Physician
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public DateTime Date { get; set; }
        public string DateDescription { get; set; }
        public string City { get; set; }
    }
}