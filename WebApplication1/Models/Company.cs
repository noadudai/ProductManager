namespace WebApplication1.Models
{
    public class Company
    {
        /*
            The Id of the company instance will be auto-incremented by the database and will not be changed. 
            Setting the 'set' accessor to private will make sure that the Id is unchangeable.
        */
        public int Id { get; private set; }

        // The name of the company instance.
        public string Name { get; set; }

        // A collection of the products that are iported by the company.
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
