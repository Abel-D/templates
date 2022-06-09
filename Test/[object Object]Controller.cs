using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Excel.Presentation
{
    [ApiVersion("v1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class  :
    {
         public PostController(   )
        {
        }

        [HttpPost]
        public async Task<Post>  AddPost(Post post , )
        {
           throw new not implemented Exception();
        }
        
    }
}
