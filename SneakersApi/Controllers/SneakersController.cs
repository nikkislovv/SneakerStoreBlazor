using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SneakerStoreBlazor.Models;

namespace SneakersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SneakersController : ControllerBase
    {
        private static readonly List<Sneakers> Sneakers = new List<Sneakers>()
        {
            new Sneakers()
            {
            Id = Guid.NewGuid(),
                Brand = "Nike",
                Model = "model 1",
                Color = "black",
                Price = 200,
                Image = "https://media.istockphoto.com/id/175537625/photo/sneakers-with-clipping-path.jpg?b=1&s=170667a&w=0&k=20&c=GzRUE7GmoRNgLG49o5AldQDgeh7fxzHddc4MVaduDvc=",
                Description = "Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info"
            },
            new Sneakers()
            {
            Id = Guid.NewGuid(),
                Brand = "Adidas",
                Model = "model 2",
                Color = "blue",
                Price = 150,
                Image = "https://media.istockphoto.com/id/1248566148/photo/pair-of-stylish-sneakers-isolated-on-white-background-white-casual-shoes.jpg?s=170667a&w=0&k=20&c=J75eAdzSckZNNlf1zizUkXKJHS1Z0qDtET0BE7hqctI=",
                Description = "Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info"
            },
            new Sneakers()
            {
            Id = Guid.NewGuid(),
                Brand = "Adidas",
                Model = "model 3",
                Color = "pink",
                Price = 300,
                Image = "https://img.freepik.com/premium-photo/blue-sport-running-shoes-white-background-sports-shoes-blue-color-trendy-sport-footwear_256259-2485.jpg?w=2000",
                Description = "Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info"
            },
            new Sneakers()
            {
            Id = Guid.NewGuid(),
                Brand = "Jordan",
                Model = "model 4",
                Color = "green",
                Price = 400,
                Image = "https://media.gq.com/photos/5e4c2c5440e46c00081a1de5/16:9/w_1280,c_limit/3x2.jpg",
                Description = "Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info"
            },
            new Sneakers()
            {
            Id = Guid.NewGuid(),
                Brand = "Nike",
                Model = "model 5",
                Color = "yellow",
                Price = 200,
                Image = "https://c4.wallpaperflare.com/wallpaper/286/94/407/adidas-images-for-desktop-background-wallpaper-preview.jpg",
                Description = "Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info"
            },
            new Sneakers()
            {
            Id = Guid.NewGuid(),
                Brand = "Jordan",
                Model = "model 4",
                Color = "green",
                Price = 400,
                Image = "https://media.gq.com/photos/5e4c2c5440e46c00081a1de5/16:9/w_1280,c_limit/3x2.jpg",
                Description = "Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info"
            },
            new Sneakers()
            {
            Id = Guid.NewGuid(),
                Brand = "Nike",
                Model = "model 5",
                Color = "yellow",
                Price = 200,
                Image = "https://c4.wallpaperflare.com/wallpaper/286/94/407/adidas-images-for-desktop-background-wallpaper-preview.jpg",
                Description = "Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info"
            },
            new Sneakers()
            {
            Id = Guid.NewGuid(),
                Brand = "Nike",
                Model = "model 1",
                Color = "black",
                Price = 200,
                Image = "https://media.istockphoto.com/id/175537625/photo/sneakers-with-clipping-path.jpg?b=1&s=170667a&w=0&k=20&c=GzRUE7GmoRNgLG49o5AldQDgeh7fxzHddc4MVaduDvc=",
                Description = "Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info"
            },
            new Sneakers()
            {
            Id = Guid.NewGuid(),
                Brand = "Adidas",
                Model = "model 2",
                Color = "blue",
                Price = 150,
                Image = "https://media.istockphoto.com/id/1248566148/photo/pair-of-stylish-sneakers-isolated-on-white-background-white-casual-shoes.jpg?s=170667a&w=0&k=20&c=J75eAdzSckZNNlf1zizUkXKJHS1Z0qDtET0BE7hqctI=",
                Description = "Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info"
            },
            new Sneakers()
            {
            Id = Guid.NewGuid(),
                Brand = "Adidas",
                Model = "model 3",
                Color = "pink",
                Price = 300,
                Image = "https://img.freepik.com/premium-photo/blue-sport-running-shoes-white-background-sports-shoes-blue-color-trendy-sport-footwear_256259-2485.jpg?w=2000",
                Description = "Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info"
            },
            new Sneakers()
            {
            Id = Guid.NewGuid(),
                Brand = "Jordan",
                Model = "model 4",
                Color = "green",
                Price = 400,
                Image = "https://media.gq.com/photos/5e4c2c5440e46c00081a1de5/16:9/w_1280,c_limit/3x2.jpg",
                Description = "Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info"
            },
            new Sneakers()
            {
            Id = Guid.NewGuid(),
                Brand = "Jordan",
                Model = "model 4",
                Color = "green",
                Price = 400,
                Image = "https://media.gq.com/photos/5e4c2c5440e46c00081a1de5/16:9/w_1280,c_limit/3x2.jpg",
                Description = "Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info"
            },
            new Sneakers()
            {
            Id = Guid.NewGuid(),
                Brand = "Nike",
                Model = "model 5",
                Color = "yellow",
                Price = 200,
                Image = "https://c4.wallpaperflare.com/wallpaper/286/94/407/adidas-images-for-desktop-background-wallpaper-preview.jpg",
                Description = "Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info"
            },
            new Sneakers()
            {
            Id = Guid.NewGuid(),
                Brand = "Jordan",
                Model = "model 4",
                Color = "green",
                Price = 400,
                Image = "https://media.gq.com/photos/5e4c2c5440e46c00081a1de5/16:9/w_1280,c_limit/3x2.jpg",
                Description = "Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info"
            },
            new Sneakers()
            {
            Id = Guid.NewGuid(),
                Brand = "Nike",
                Model = "model 5",
                Color = "yellow",
                Price = 200,
                Image = "https://c4.wallpaperflare.com/wallpaper/286/94/407/adidas-images-for-desktop-background-wallpaper-preview.jpg",
                Description = "Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info"
            },
            new Sneakers()
            {
            Id = Guid.NewGuid(),
                Brand = "Nike",
                Model = "model 1",
                Color = "black",
                Price = 200,
                Image = "https://media.istockphoto.com/id/175537625/photo/sneakers-with-clipping-path.jpg?b=1&s=170667a&w=0&k=20&c=GzRUE7GmoRNgLG49o5AldQDgeh7fxzHddc4MVaduDvc=",
                Description = "Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info Some Info"
            }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Sneakers);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(Guid Id)
        {
            return Ok(Sneakers.FirstOrDefault(e => e.Id == Id));
        }
    }
}
