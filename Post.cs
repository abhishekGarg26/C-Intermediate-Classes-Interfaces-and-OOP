using System;

namespace Classes
{
    public class Post
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public DateTime DateTimeCreate { get; set; }
        public int Upvote { get; set; }
        public int Downvote { get; set; }
      

        public Post(string title="New Post",string desc="This is a new post.")
        {
            this.Title = title;
            this.Desc = desc;
            this.DateTimeCreate = DateTime.Now;
        }

        public void voteCount(int resp)
        {
            if (resp == 1) Upvote++;
            if (resp == 2) Downvote++;          
        }



    }
}
