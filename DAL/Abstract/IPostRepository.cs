using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Abstract
{
   public interface IPostRepository
    {
        IList<Post> GetPosts();

        void CretePost(Post post);
    }
}
