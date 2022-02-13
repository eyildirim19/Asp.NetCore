using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Models
{
    public class CategoryRepository : IRepository<Category>
    {
        public List<Category> List()
        {
            // Kategorinin bir kaynaktan (db) geldiğini düşünelim..
            List<Category> katList = new List<Category>();
            katList.Add(new Category
            {
                Name = "Apartments",
                IconPath = "search-icon-01.png",
                Title = "One Of The Most Trending Stuffs Right Now!",
                Description = "Plot Listing is a responsive Bootstrap 5 website template that included 4 different HTML pages. This template is provided by TemplateMo website. You can apply this layout for your static or dynamic CMS websites.",
                LargeImage = "tabs-image-01.jpg"
            });

            katList.Add(new Category
            {
                Name = "Food & Life",
                IconPath = "search-icon-02.png",
                Title = "Food and Lifestyle category is here",
                Description = "You can feel free to download, edit and apply this template for your website. Please tell your friends about TemplateMo website.",
                LargeImage = "tabs-image-02.jpg"
            });


            katList.Add(new Category
            {
                Name = "Cars",
                IconPath = "search-icon-03.png",
                Title = "Best car rentals for your trips!",
                Description = "Did you know? You can get the best free HTML templates on Too CSS blog. Visit the blog pages and explore fresh and latest website templates.",
                LargeImage = "tabs-image-03.jpg"
            });

            katList.Add(new Category
            {
                Name = "Shopping",
                IconPath = "search-icon-04.png",
                Title = "Shopping List: Images from Unsplash",
                Description = "Image credits go to Unsplash website that provides free stock photos for anyone. Images used in this Plot Listing template are from Unsplash.",
                LargeImage = "tabs-image-04.jpg"
            });

            katList.Add(new Category
            {
                Name = "Traveling",
                IconPath = "search-icon-05.png",
                Title = "Information and Safety Tips for Traveling",
                Description = "deneme selam merhaba",
                LargeImage = "tabs-image-05.jpg"
            });

            return katList;
        }
    }
}