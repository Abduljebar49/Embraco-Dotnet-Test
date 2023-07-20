using SinglePageTestWebsite.Dtos;

namespace SinglePageTestWebsite.Entities
{
    public record TestApi
    {
        public int Id { get; init; }
        public int UserId { get; init; }
        public string Title { get; set; }
        public string Body { get; set; }

        internal TestApi asDto(TestApi testApi)
        {
            return new TestApi
            {
                Id = testApi.Id,
                UserId = testApi.UserId,
                Title = testApi.Title,
                Body = testApi.Body,
            };
        }
    }
}
