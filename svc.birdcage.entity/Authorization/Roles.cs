namespace svc.birdcage.entity.Authorization;

[Index(propertyName: "RoleName", IsUnique = true)]
public class Roles : BaseCreateAuditEntity
{
    public required string RoleName { get; set; }

    public required string DisplayName { get; set; }

    public required string Discription { get; set; }

}