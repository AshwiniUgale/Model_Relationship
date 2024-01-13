namespace WebApp6.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Prize { get; set; }

        //oneToMany RelationShip with category

        public int CategoryId { get; set; } //forign key

        public Category Category { get; set; } //Navigation Property


    }
}
