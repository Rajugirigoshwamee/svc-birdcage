namespace svc.birdcage.parrot.Authorization
{
    public class Branches : BaseCreateAuditEntity
    {
        public required string Name { get; set; }
        public required string MobileNo { get; set; }
        public required string Email { get; set; }
    }
}
