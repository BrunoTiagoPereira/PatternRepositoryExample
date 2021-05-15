namespace PatternRepository
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int id, string nome)
        {
            Name = nome;
            Id = id;
        }
    }
}