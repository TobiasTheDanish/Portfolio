namespace BlazorWasmTest.Models
{
    public class ProjectModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string[]? Tags { get; set; }

        public ProjectModel(string? name, string? description, string[]? tags)
        {
            Name = name;
            if (description != null && description.Length > 50)
            {
                Description = description.Substring(0, 50).TrimEnd() + "...";
            }
            else
            {
                Description = description;
            }

            Tags = tags;
        }
    }
}
