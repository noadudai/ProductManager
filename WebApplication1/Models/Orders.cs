// A namespace in .Net that provides attributes and classes for configuring and controlling
// the database schema and mappings.
using System.ComponentModel.DataAnnotations.Schema;  // [DatabaseGenerated] Attribute

namespace WebApplication1.Models
{
    // An order table contains a collection of order items with a specific date and time.
    public class Orders
    {
        /*
            The Id of the order instance will be auto-incremented by the database and will not be changed. 
            Setting the 'set' accessor to private will make sure that the Id is unchangeable.
        */
        public int Id { get; private set; }

        /*
            The date of the order. The DatabaseGenerated attribute specifies how values are
            generated for a property by the database.  The attribute takes a DatabaseGeneratedOption 
            enumeration value, which in this case is 'DatabaseGeneratedOption.Computed'.
        */
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Date { get; set; }

        // A collection of the products in an order.
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
