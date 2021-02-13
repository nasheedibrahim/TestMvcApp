using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMvcApp.Models;

namespace TestMvcApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post { Id=1, Name = "Sample Post 2", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", Slug = "sample-post-1", BannerUrl = "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg" },
                new Post { Id=2, Name = "Sample Post 1", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", Slug = "sample-post-1", BannerUrl = "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg" },
                new Post { Id=3, Name = "Sample Post 3", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", Slug = "sample-post-1", BannerUrl = "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg" },
                new Post { Id=4, Name = "Sample Post 4", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", Slug = "sample-post-1", BannerUrl = "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg" },
                new Post { Id=5, Name = "Sample Post 5", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", Slug = "sample-post-1", BannerUrl = "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg" },
                new Post { Id=6, Name = "Sample Post 6", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", Slug = "sample-post-1", BannerUrl = "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg" },
                new Post { Id=7, Name = "Sample Post 7", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", Slug = "sample-post-1", BannerUrl = "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg" },
                new Post { Id=8, Name = "Sample Post 8", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", Slug = "sample-post-1", BannerUrl = "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg" },
                new Post { Id=9, Name = "Sample Post 9", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", Slug = "sample-post-1", BannerUrl = "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg" },
                new Post { Id=10, Name = "Sample Post 10", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", Slug = "sample-post-1", BannerUrl = "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg" },
                new Post { Id=11, Name = "Sample Post 11", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", Slug = "sample-post-1", BannerUrl = "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg" },
                new Post { Id=12, Name = "Sample Post 12", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", Slug = "sample-post-1", BannerUrl = "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg" },
                new Post { Id=13, Name = "Sample Post 14", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", Slug = "sample-post-1", BannerUrl = "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg" },
                new Post { Id=14, Name = "Sample Post 14", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", Slug = "sample-post-1", BannerUrl = "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg" });
        }
    }
}
