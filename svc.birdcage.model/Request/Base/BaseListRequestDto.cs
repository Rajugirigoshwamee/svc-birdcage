namespace svc.birdcage.model.Request.Base;

public class BaseListRequestDto
{
    public int PageSize { get; set; } = 10;
    public int PageNo { get; set; } = 10;
    public string? SortBy { get; set; } = null;
    public string? Search { get; set; } = null;
    public Guid? Id { get; set; } = null;
}
