namespace svc.birdcage.parrot.Masters;

public class Languages : BaseCreateAuditEntity
{
    [StringLength(100)]
    public required string Name { get; set; }

    [StringLength(10)]
    public required string Code { get; set; }

    public required string Flag { get; set; }

    public string? Description { get; set; }
}
