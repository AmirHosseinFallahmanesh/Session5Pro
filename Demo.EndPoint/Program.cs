using Demo.Dal;
using System;

namespace Demo.EndPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoContext context = new DemoContext();
            //context.Database.EnsureDeleted();
            
            
           context.Database.EnsureCreated();
            Blog blog = new Blog() { Url = "http" };
            context.Blogs.Add(blog);
            context.Entry(blog).Property("CreateTime").CurrentValue = DateTime.Now;
           context.Entry(blog).Property("LastUpdateTime").CurrentValue = DateTime.Now;
            context.SaveChanges();

            var bloag = context.Blogs.Find(1);
            Post post = new Post()
            {
               Title = "test",
                Url = "http",
               Blog = bloag
           };
            context.SaveChanges();
            var b = context.Posts.Find(1);
           
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
