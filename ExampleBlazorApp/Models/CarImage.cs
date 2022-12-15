namespace ExampleBlazorApp.Models
{
    public class CarImage
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string URL { get; set; } = string.Empty;

        public int ImageView { get; set; } = 1;

        public virtual Car Car { get; set; } 
    }
}
