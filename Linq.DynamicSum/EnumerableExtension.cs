using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Linq.DynamicSum
{
    public static class EnumerableExtension
    {
        // Summary:
        //     Returns the the sum object of a sequence.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to return the first element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     Returns the the sum object of a sequence.
        //     Returns new object if source is null
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.       
        public static TSource DynamicSum<TSource>(this IEnumerable<TSource> source)
        {
            if (source.Any())
            {
                var addFunc = GenAddFunc<TSource>();
                return source.Aggregate(addFunc);
            }

            return Activator.CreateInstance<TSource>();
        }

        // Summary:
        //     Returns the the sum object of a sequence.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to return the first element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     Returns the the sum object of a sequence.
        //     Returns @default if source is null
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.       
        public static TSource DynamicSum<TSource>(this IEnumerable<TSource> source, TSource @default)
        {
            if (source.Any())
            {
                var addFunc = GenAddFunc<TSource>();
                return source.Aggregate(addFunc);
            }

            return @default;
        }

        public static Func<T, T, T> GenAddFunc<T>()
        {
            var parameterExpression1 = Expression.Parameter(typeof(T));
            var parameterExpression2 = Expression.Parameter(typeof(T));
            var addExpression = Expression.Add(
                Expression.Convert(parameterExpression1, typeof(T)),
                Expression.Convert(parameterExpression2, typeof(T)));
            return Expression.Lambda<Func<T, T, T>>(
                            Expression.Convert(addExpression, typeof(T)),
                            parameterExpression1,
                            parameterExpression2)
                            .Compile();
        }
    }
}
