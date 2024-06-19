using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Post
    {
        int id = 0;
        public string Title { get; set; }
        public string Description { get; set; }
        public int LikeCount { get; set; }
        public string [] Comments { get; set; } = new string[5];
        public bool IsPublished { get; set; }

        public void Publish()
        {
            Console.WriteLine("The post is published.");
            IsPublished = true;
        }
        public int Like()
        {
            return LikeCount++;
        }
        public void Comment(string message)
        {
            Comments[id] = message;
            id++;
        }



    }
}
