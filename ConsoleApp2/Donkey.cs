namespace ConsoleApp2
{
    public class Donkey
    {
        public string Name { get; set; }
        public string Registration { get; set; }
        public DateTime? DOB { get; set; }
        public DateTime? Date_Registered { get; set; }
        public string Deceased { get; set; }
        public string Breed { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"Name: {Name} " +
                $"Regno: {Registration} " +
                $"DOB: {(DOB.HasValue ? DOB.Value.ToShortDateString() : "NULL")} " +
                $"Date Registered: {(Date_Registered.HasValue ? Date_Registered.Value.ToShortDateString() : "NULL")} " +
                $"Deceased: {Deceased} " +
                $"Breed: {Breed} " +
                $"Desc: {Description}";
        }
    }
}