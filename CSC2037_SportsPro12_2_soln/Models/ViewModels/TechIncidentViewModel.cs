namespace CSC2037_SportsPro12_2_soln.Models
{
    public class TechIncidentViewModel
    {
        public Technician Technician { get; set; } = null!;
        public Incident Incident { get; set; } = null!;
        public IEnumerable<Incident> Incidents { get; set; } = null!;
    }
}
