using System.Collections.Generic;
using System.Linq;
using SinglePageTestWebsite.Entities;

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

        public IEnumerable<TestApi> GetTestApis()
        {
            return TestApis;
        }
    }
}
