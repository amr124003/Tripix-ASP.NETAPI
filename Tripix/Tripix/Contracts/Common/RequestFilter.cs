namespace Tripix.Contracts.Common
{
    public class RequestFilter
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public Dictionary<string, string> SearchValues { get; set; } = new Dictionary<string, string>();
        public string? SortCloumn { get; set; }
        public string? SortDirection { get; set; } = "ASC";
    }
}
