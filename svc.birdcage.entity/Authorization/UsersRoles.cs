namespace svc.birdcage.entity.Authorization;

public class UsersRoles : BaseDeletedAuditEntity
{
    public required Guid UserId { get; set; }
    [ForeignKey("UserId")]
    public Users? UserIdByFk { get; set; }

    public required Guid RoleId { get; set; }
    [ForeignKey("RoleId")]
    public Roles? RoleIdByFk { get; set; }
}