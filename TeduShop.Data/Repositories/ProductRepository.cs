using System;
using System.Linq.Expressions;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{ 
    public interface IProductRepository : IRepository<Product>
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public override bool CheckCotains(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}