using svc.birdcage.parrot.Enums;

namespace svc.birdcage.parrot.Authorization
{
    public class Permission : BaseCreateAuditEntity
    {
        public required string Name { get; set; }
        public required PermissionType Type { get; set; }
    }
}
