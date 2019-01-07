using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ThirdPartyApi.Model;
using System.IO;
using System.Net.Http;

namespace RWRAP_API.ThirdPartyApi.Controller
{
    [Route("api/blogs")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        public BlogsController()
        {
        }
        [HttpGet]
        public object Blogs()
        {
            List<Blogs> blogs = new List<Blogs>();
            blogs.Add(new Blogs() { Name = "MOBILE", path = "https://www.v2solutions.com/category/mobile/" });
            blogs.Add(new Blogs() { Name = "QA", path = "https://www.v2solutions.com/category/qa/" });
            blogs.Add(new Blogs() { Name = "TECHNOLOGY", path = "https://www.v2solutions.com/category/technology/" });

            return blogs;
        }
    }
}