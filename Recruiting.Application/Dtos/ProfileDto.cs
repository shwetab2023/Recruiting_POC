namespace Recruiting.Application.Dtos;

public record ProfileDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string City { get; set; }
    public string School { get; set; }
    public int Experience { get; set; }
    public int Age { get; set; }

}
