using System.Collections.Generic;
using System;
using System.Linq;

namespace DemoExcel.presentation
{
    public class PostService  :CRUD
    {

        private readonly PostRepository _postRepository;

        public PostService(   PostRepository postRepository, )
        {

            _postRepository = postRepository; 

        }

        public async Task<Post>  AddPost(Post post , )
        {
            try
            {
                throw not implemented Exception();
            }
            catch (Exception e)
            {
                return new Exception(e);
            }
        }
        public async IEnumerable<Post>  GetPosts()
        {
            try
            {
                throw not implemented Exception();
            }
            catch (Exception e)
            {
                return new Exception(e);
            }
        }
        public async IEnumerable<Post>  GetPostById(string id , )
        {
            try
            {
                throw not implemented Exception();
            }
            catch (Exception e)
            {
                return new Exception(e);
            }
        }
    }
}
