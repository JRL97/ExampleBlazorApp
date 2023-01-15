using System.Drawing;

namespace ExampleBlazorApp.Models
{
    public class CarImage
    {
        public int Id { get; set; } = 0;
        public int CarId { get; set; }
        public string URL { get; set; } = string.Empty;


        //public int ImageView { get; set; } = 1;

        public virtual Car Car { get; set; }

        //public CarImage(int carId, string url, int imageView) 
        //{
        //    CarId = carId;
        //    URL = url;
        //    ImageView = imageView;
        //}
    }
    //public Image CarImage(int carId, string imageCarousel)
    //{
    //    CarId = carId;
    //    ImageCarousel = imageCarousel;
    //}
}
