namespace svc.birdcage.entity.Base;

[Index(propertyName: "IsDeleted", IsUnique = false)]
[Index(propertyName: "DeletedBy")]
[Index(propertyName: "DeletedDate")]
public class BaseDeletedAuditEntity : BaseIdEntity
{
    public bool IsDeleted { get; set; } = false;

    public Guid? DeletedBy { get; set; }
    [ForeignKey("DeletedBy")]
    public Users? DeletedByFk { get; set; }

    public DateTime? DeletedDate { get; set; }

    public BaseDeletedAuditEntity()
    {
        DeletedDate = DateTime.UtcNow;
    }
}