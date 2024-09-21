namespace svc.birdcage.model.Response.Base
{
    public class BasePaginationResponse<T> where T : class
    {
        public int Total { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int Offset { get; set; }
        public IEnumerable<T> Details { get; set; }
    }
}
