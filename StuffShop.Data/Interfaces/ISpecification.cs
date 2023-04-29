using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace StuffShop.Data.Interfaces
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }

        List<Func<IQueryable<T>, IIncludableQueryable<T, object>>> Includes { get; }

        Expression<Func<T, object>> OrderBy { get; }

        Expression<Func<T, object>> OrderByDescending { get; }
    }
}