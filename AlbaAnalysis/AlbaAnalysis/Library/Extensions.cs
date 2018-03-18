using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis.Library {
    public static class Extensions {
        public static List<double> Convert2DoubleList(this string[] source) {
            return source.Select(i => {
                if (!double.TryParse(i, out var r))
                    return 0;
                return r;
            }).ToList();
        }
    }
}
