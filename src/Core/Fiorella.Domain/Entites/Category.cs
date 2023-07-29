using Fiorella.Domain.Entites.Common;

namespace Fiorella.Domain.Entites;

public class Category:BaseEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }    
}
