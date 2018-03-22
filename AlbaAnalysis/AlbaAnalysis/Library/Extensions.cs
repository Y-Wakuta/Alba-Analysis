using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis.Library
{
    public static class Extensions
    {
        public static List<double> Convert2DoubleList(this string[] source)
        {
            return source.Select(i =>
            {
                if (!double.TryParse(i, out var r))
                    return 0;
                return r;
            }).ToList();
        }

        public static IOrderedEnumerable<PropertyInfo> GetSortedProperties<T>(this T t) where T : Type
        {
            return t
              .GetProperties()
              .OrderBy(p => (p.GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault() as DisplayAttribute)?.Order ?? int.MaxValue);
        }
    }
}
