using DataContract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Abstract
{
   public interface IPostService
    {
        IList<PostDto> GetPosts();

        void CreatePost(PostDto dto);
    }
}
