using System;
using System.Linq.Expressions;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IOrderDetailRepository :  IRepository<OrderDetail>
    {
    }

    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public override bool CheckCotains(Expression<Func<OrderDetail, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}