using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Tripix.Abstractions;
using Tripix.Entities;

namespace Tripix.Extentions
{
    public static class PaginationHelper
    {
        public static IQueryable<T> ApplyFilter<T> ( this IQueryable<T> Query, Dictionary<string, string> filters )
        {
            var Parameter = Expression.Parameter(typeof(T), "x");

            Expression filterExpression = null;

            var propertyName = "";
            var propertyValue = "";
            var Operation = "equal";

            if(filters == null) { return  Query; }

            foreach (var filter in filters)
            {
                propertyName = filter.Key;
                propertyValue = filter.Value;

                if(string.IsNullOrEmpty(propertyValue))
                {
                    continue;
                }

                if(propertyName.ToLower() == "minprice" || propertyName.ToLower().StartsWith("min"))
                {
                    Operation = propertyName;
                    propertyName = "price";
                }

                else if(propertyName.ToLower() == "maxprice" || propertyName.ToLower().StartsWith("max"))
                {
                    Operation = propertyName;
                    propertyName = "price";
                }
                

                var property = Expression.Property(Parameter, propertyName);
                var propertyType = property.Type;

                var UnderlyingType = Nullable.GetUnderlyingType(propertyType) ?? propertyType;

                object ComparedValue;

                if (UnderlyingType.IsEnum)
                {
                    ComparedValue = Enum.Parse(UnderlyingType, propertyValue);
                }
                else
                {
                    ComparedValue = Convert.ChangeType(propertyValue, UnderlyingType);
                }

                Expression exoperation;


                var Constant = Expression.Constant(ComparedValue, propertyType);

                switch(Operation.ToLower())
                {
                    case "minprice":
                        exoperation = Expression.GreaterThanOrEqual(property, Constant);
                        break;

                    case "maxprice":
                        exoperation= Expression.LessThanOrEqual(property, Constant);
                        break;

                    default:
                        exoperation = Expression.Equal(property, Constant);
                        break;

                }

                filterExpression = filterExpression == null ? exoperation : Expression.AndAlso(filterExpression, exoperation);
            }

            if (filterExpression != null)
            {
                var lambda = Expression.Lambda<Func<T, bool>>(filterExpression, Parameter);

                Query = Query.Where(lambda);
            }

            return Query;
        }

        public static async Task<PaginatedList<T>> CreatePaginatedList<T> ( this IQueryable<T> Items, int pageNumber,
            int pageSize, CancellationToken CanToken )
        {
            var itemsCount = await Items.CountAsync(CanToken);
            var items = await Items.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync(CanToken);

            return new PaginatedList<T>(items, pageNumber, itemsCount, pageSize);
        }
    }
}
