namespace svc.birdcage.parrot.Masters;

public class Areas : BaseCreateAuditEntity
{
    [StringLength(100)]
    public required string Name { get; set; }

    [StringLength(10)]
    public required string PinCode { get; set; }

    public required Guid? CityId { get; set; }
    [ForeignKey("CityId")]
    public required Cities? CityIdByFk { get; set; }

    public required Guid? StateId { get; set; }
    [ForeignKey("StateId")]
    public required States? StateIdByFk { get; set; }

    public required Guid? CountryId { get; set; }
    [ForeignKey("CountryId")]
    public required Countries? CountryIdByFk { get; set; }
}
