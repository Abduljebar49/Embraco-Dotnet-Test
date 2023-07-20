namespace SinglePageTestWebsite.Dtos
{
    public record TestApiDto
    {
        public int UserId { get; init; }
        public int Id { get; init; }
        public required string Title { get; set; }
        public required string Body { get; set; }
    }
}
