namespace svc.birdcage.entity.Masters;

public class States : BaseCreateAuditEntity
{
    [StringLength(100)]
    public required string Name { get; set; }
    public string? Description { get; set; }

    public required Guid? CountryId { get; set; }
    [ForeignKey("CountryId")]
    public required Countries? CountryIdByFk { get; set; }
}
