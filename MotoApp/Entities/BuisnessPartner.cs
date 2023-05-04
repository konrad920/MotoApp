namespace MotoApp.Entities
{
    public class BuisnessPartner : EntityBase
    {
        public string? Name { get; set; }

        public override string ToString()
        {
            return ($"Id: {Id}, Name: {Name}");
        }
    }
}
