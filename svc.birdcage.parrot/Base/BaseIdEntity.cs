namespace svc.birdcage.parrot.Base;

public class BaseIdEntity
{
    [Key]
    public Guid Id { get; set; } = new Guid();

    public Guid? TenantId { get; set; }
    [ForeignKey("TenantId")]
    public Tenant? TenantIdFK { get; set; }

    public Guid? BranchId { get; set; }
    [ForeignKey("BranchId")]
    public Branches? BranchIdFK { get; set; }
}
