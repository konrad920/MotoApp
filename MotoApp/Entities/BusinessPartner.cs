namespace MotoApp.Entities
{
    public class BusinessPartner : EntityBase
    {
        public string? FirstName { get; set; }//przez znak ? pozwalamy na wartosc null w naszej propercji

        public override string ToString()
        {
            return $"Id: {Id}, Firstname: {FirstName}";
        }
    }
}
