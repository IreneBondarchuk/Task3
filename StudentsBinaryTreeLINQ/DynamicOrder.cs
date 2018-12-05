using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Reflection;

namespace StudentsBinaryTreeLINQ
{
    public static class DynamicOrder
    {
        public static IEnumerable<T> OrderBy<T>(this IEnumerable<T> source, string propertyName)
        {
            ParameterExpression parameterExpression = Expression.Parameter(typeof(T), "x");
            Expression propertyExpression = Expression.Property(parameterExpression, propertyName);

            var resultExpression = Expression.Lambda(propertyExpression, parameterExpression);

            var lambda = resultExpression.Compile();

            Type enumerableType = typeof(Enumerable);
            var methods = enumerableType.GetMethods(BindingFlags.Static | BindingFlags.Public);
            var selectedMethods = methods.Where(n => n.Name == "OrderBy" && n.GetParameters().Count() == 2);

            var method = selectedMethods.First();

            method = method.MakeGenericMethod(typeof(T), propertyExpression.Type);

            var result = (IEnumerable<T>)method.Invoke(null, new object[] { source, lambda });

            return result;



        }
    }
}
