using System;
using System.Linq.Expressions;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    {
    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public override bool CheckCotains(Expression<Func<Tag, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}