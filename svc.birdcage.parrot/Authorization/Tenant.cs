namespace svc.birdcage.parrot.Authorization;

[Index(propertyName: "Name", "MobileNo", IsUnique = true)]
public class Tenant
{
    [Key]
    public Guid Id { get; set; } = new Guid();
    public required string Name { get; set; }
    public required string MobileNo { get; set; }
    public required string Email { get; set; }
}