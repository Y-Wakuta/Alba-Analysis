using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

using AlbaAnalysis.Entity;

namespace AlbaAnalysis.AdditionalPanel {
    public class ConfigDialogDataHandler {

        public ConfigDialogDataHandler(BindingSource abd) {
            var List = new BindingList<DisplayOrderAttribute>(GetNamesOrdered());
            abd.DataSource = List;
        }

        public List<DisplayOrderAttribute> GetNamesOrdered() {
            var attrList = new List<DisplayOrderAttribute>();
            foreach (var f in typeof(SerialEntity).GetFields()) {
                var test = Attribute.GetCustomAttribute(f, typeof(DisplayOrderAttribute)) as DisplayOrderAttribute;
                attrList.Add(test);
            }
            return attrList.OrderBy(a => a.order).ToList();
        }

        public string GetSEName(string str) {
            var field = typeof(SerialEntity).GetField(str);
            var attr = Attribute.GetCustomAttribute(field, typeof(DisplayOrderAttribute)) as DisplayOrderAttribute;
            return attr != null ? attr.name : str + "Attribute not Found";
        }
    }
}
