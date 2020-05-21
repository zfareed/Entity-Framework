using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DataBaseFirstDemoEntities();
            var post = new Post()
            {
                Body = "Body1",
                PostID = 1,
                DatePublished = DateTime.Now,
                Title = "Title1"
            };
            context.Posts.Add(post);
            context.SaveChanges();



        }
    }
}
