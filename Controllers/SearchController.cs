using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SinglePageTestWebsite.Entities;
using Umbraco.Cms.Web.Common.Controllers;

namespace SinglePageTestWebsite.Controllers
{
    [ApiController]
	[Route("Api/[controller]")]
    public class SearchController : UmbracoApiController
    {
        private readonly ITestApiRepository repository;

        public SearchController(ITestApiRepository repository)
        {
            this.repository = repository;
        }
        //umbraco/api/search
        [HttpGet("search")]
        public IEnumerable<TestApi> Search(string q)
        {
            var results = repository.GetResult(q).Select(item => item.asDto(item));
            return results;
        }

        [HttpGet()]
        public IEnumerable<TestApi> SearchQ([FromQuery] string q)
        {

            var results = repository.GetResult(q).Select(item => item.asDto(item));
            return results;
        }


        // [HttpGet]
        // public string testText(){
        //     return "this is text";
        // }
    }
}
