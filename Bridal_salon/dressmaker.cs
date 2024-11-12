namespace Bridal_salon
{
    [Flags]
    public enum days { Sunday=1, Monday=2, Tuesday=4, WWednesday=8, Thursday=16, Friday=32}
    public class dressmaker
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public days Working_days_a_week { get; set; }
        public int Hourly_wage { get; set; }
        public double Experience { get; set; }

        
    }
}
