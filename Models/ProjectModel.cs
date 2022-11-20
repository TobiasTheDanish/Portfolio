namespace BlazorWasmTest.Models
{
    public class ProjectModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ShortDescription { get; set; }
        public string[]? Tags { get; set; }
        public string[]? Images { get; set; }

        public ProjectModel(string? name, string? description, string[]? tags, string[]? images)
        {
            Name = name;
            Description = description;
            if (description != null && description.Length > 50)
            {
                ShortDescription = description.Substring(0, 50).TrimEnd() + "...";
            }
            else
            {
                ShortDescription = description;
            }

            Tags = tags;
            Images = images;
        }
    }
}
