namespace svc.birdcage.parrot.Authorization;

[Index(propertyName: "RoleName", IsUnique = false)]
public class Roles : BaseCreateAuditEntity
{
    public required string RoleName { get; set; }

    public required string DisplayName { get; set; }

    public required string Discription { get; set; }

}