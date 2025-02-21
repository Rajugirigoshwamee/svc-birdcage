namespace svc.birdcage.parrot.Masters;

[Index(propertyName: "Name", IsUnique = true)]
public class Countries : BaseCreateAuditEntity
{
    [StringLength(100)]
    public required string Name { get; set; }
    public required string Code { get; set; }
    public required string MobileCode { get; set; }
    public required string FlagUrl { get; set; }
    public string? Description { get; set; }
}
