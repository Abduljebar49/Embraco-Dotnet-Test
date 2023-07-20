using System.Collections.Generic;
using System.Linq;
using SinglePageTestWebsite.Entities;
using Umbraco.Cms.Core.Models;
namespace SinglePageTestWebsite.Repositories
{
    public class TestApiRepository : ITestApiRepository
    {
        public readonly List<TestApi> TestApis =
            new()
            {
                new TestApi
                {
                    Id = 1,
                    UserId = 2,
                    Title = "this is title",
                    Body = " this is body"
                },
                new TestApi
                {
                    Id = 2,
                    UserId = 2,
                    Title = "this is title",
                    Body = " this is body"
                },
                new TestApi
                {
                    Id = 3,
                    UserId = 2,
                    Title = "this is title",
                    Body = " this is body"
                },
            };

        public IEnumerable<TestApi> GetResult(string q)
        {
            IEnumerable<TestApi> searchResults = Enumerable.Empty<TestApi>();
            if (!string.IsNullOrWhiteSpace(q))
            {
                // searchResults = Umbraco.ContentQuery.Search(q).Where(x => x.IsVisible()).Take(10);
                searchResults = TestApis.Where(p => p.Title == q).Take(10);
            }
            var results = searchResults.Select(
                x =>
                    new TestApi
                    {
                        Title = x.Title,
                        Body = x.Body,
                        Id = x.Id,
                        UserId = x.UserId
                    }
            );
            return results;
        }

        public IEnumerable<TestApi> GetTestApis()
        {
            return TestApis;
        }
    }
}
