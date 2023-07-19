namespace Fiorella.Domain.Entites.Common;

public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
}
