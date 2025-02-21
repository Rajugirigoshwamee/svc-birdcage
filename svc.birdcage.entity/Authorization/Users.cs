namespace svc.birdcage.parrot.Authorization;

[Index(propertyName: "Username", "Password", IsUnique = true)]
public class Users : BaseCreateAuditEntity
{
    public required string Name { get; set; }
    public required string MobileNo { get; set; }
    public required string Surname { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required string Email { get; set; }
}