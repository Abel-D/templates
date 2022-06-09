using System.Collections.Generic;
using System;
using System.Linq;

namespace DemoExcel.presentation{
  
public interface IPostService
{

 Task<Post> AddPost(Post post , );
 IEnumerable<Post> GetPosts();
 IEnumerable<Post> GetPostById(string id , );

}
}
