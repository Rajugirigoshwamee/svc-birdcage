namespace svc.birdcage.entity.Base;

public class BaseIdEntity
{
    [Key]
    public Guid Id { get; set; } = new Guid();

    public Guid? TenantId { get; set; }
    [ForeignKey("TenantId")]
    public Tenant? TenantIdFK { get; set; }
}
