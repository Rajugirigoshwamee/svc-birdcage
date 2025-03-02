namespace svc.birdcage.parrot.Authorization
{
    public class Branches 
    {
        [Key]
        public Guid Id { get; set; } = new Guid();
        public required string Name { get; set; }
        public required string MobileNo { get; set; }
        public required string Email { get; set; }
    }
}
