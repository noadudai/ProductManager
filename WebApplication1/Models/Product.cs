namespace WebApplication1.Models
{
    public class Product
    {
        /*
            The Id of the product instance will be auto-incremented by the database and will not be changed. 
            Setting the 'set' accessor to private will make sure that the Id is unchangeable.
        */
        public int Id { get; private set; }

        // The name of the product.
        public string Name { get; set; }

        /*// Many-to-one relationship with company.
        public Company Company { get; set; }

        // Many-to-one relationship with orders.
        public Orders Order { get; set; }*/
    }
}
