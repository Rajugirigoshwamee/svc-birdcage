using System.ComponentModel.DataAnnotations;

namespace svc.birdcage.entity.Masters;

[Index(propertyName: "Name", IsUnique = true)]
public class Countries : BaseCreateAuditEntity
{
    [StringLength(100)]
    public required string Name { get; set; }
    public string? Description { get; set; }
}
