namespace svc.birdcage.parrot.Base;

[Index(propertyName: "CreateBy", IsUnique = false)]
[Index(propertyName: "CreateDate", IsUnique = false)]
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
