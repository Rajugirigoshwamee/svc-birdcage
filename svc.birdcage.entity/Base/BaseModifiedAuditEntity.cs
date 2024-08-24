namespace svc.birdcage.entity.Base;

[Index(propertyName: "ModifiedBy")]
[Index(propertyName: "ModifiedDate")]
public class BaseModifiedAuditEntity : BaseDeletedAuditEntity
{
    public Guid? ModifiedBy { get; set; }
    [ForeignKey("ModifiedBy")]
    public Users? ModifiedByFk { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public BaseModifiedAuditEntity()
    {
        ModifiedDate = DateTime.UtcNow;
    }
}