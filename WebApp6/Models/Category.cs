namespace WebApp6.Models
{
    public class Category
    {

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //one to many relationShip with Product Model

        public ICollection<Product> products { get; set;}
    }
}