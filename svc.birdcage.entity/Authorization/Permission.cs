using svc.birdcage.model.Enums;

namespace svc.birdcage.entity.Authorization
{
    public class Permission : BaseCreateAuditEntity
    {
        public required string Name { get; set; }
        public required PermissionType Type { get; set; }
    }
}
