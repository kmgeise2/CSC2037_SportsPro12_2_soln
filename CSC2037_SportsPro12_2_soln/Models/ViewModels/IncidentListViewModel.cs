namespace CSC2037_SportsPro12_2_soln.Models
{
    public class IncidentListViewModel
    {
        public string Filter { get; set; } = string.Empty;
        public IEnumerable<Incident> Incidents { get; set; } = null!;
    }
}
