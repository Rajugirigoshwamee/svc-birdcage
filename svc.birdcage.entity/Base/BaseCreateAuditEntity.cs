namespace svc.birdcage.entity.Base;

[Index(propertyName: "CreateBy", IsUnique = false)]
[Index(propertyName: "CreateDate", IsUnique = true)]
public class BaseCreateAuditEntity : BaseModifiedAuditEntity
{

    public Guid? CreateBy { get; set; }
    [ForeignKey("CreateBy")]
    public Users? CreateByFK { get; set; }

    public DateTime CreateDate { get; set; }

    public BaseCreateAuditEntity()
    {
        CreateDate = DateTime.UtcNow;
    }

}
