using Tripix.Abstractions;
using Tripix.Contracts.Helpoo;
using Tripix.Entities;
using Tripix.View_Models;

namespace Tripix.Services.Interfaces
{
    public interface Ihelpoo
    {
        public Task<Result<HelpooOrders>> GetOrderDetails ( int Id, string UserId );
        public List<HelpooOrders> GetOrders ();
        public Task<Result<HelpooOrders>> OrderHelpoo ( string UserId, OrderHelpooDTO model );
        public Task<Result<HelpooOrders>> UpdateOrderDetials (string UserId , UpdateHelpooDTO order );
        public Task<Result> DeleteOrder ( int Id );
        public  Task<Result> CancelOrder ( string UserId, int Id );
    }
}
