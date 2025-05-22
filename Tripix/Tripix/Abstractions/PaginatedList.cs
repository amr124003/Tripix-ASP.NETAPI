using Microsoft.EntityFrameworkCore;

namespace Tripix.Abstractions
{
    public  class PaginatedList<T>
    {
        public  PaginatedList (List<T> items , int pageNumber , int itemsCount , int pageSize)
        {
            Items = items ;
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(itemsCount / (double)pageSize);
        }
        public  List<T> Items { get; private set; }
        public  int PageNumber { get; private set; }
        public  int TotalPages {  get; private set; }
        public  bool HasPrevPage => PageNumber > 1;
        public  bool HasNextPage => PageNumber < TotalPages;

       

    }
}
