using System;
using System.Linq.Expressions;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IOrderRepository  : IRepository<Order>
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public override bool CheckCotains(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}