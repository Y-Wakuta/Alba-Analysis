using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis.Entity
{
    public abstract class BaseEntity : INotifyPropertyChanged
    {
        public double BaseUnixTime {
            get { return _start_unix_time; }
            set {
                _start_unix_time = value;
                onPropertyChanged(nameof(BaseUnixTime));
            }
        }
        private double _start_unix_time;

        public T Clone<T>()
        {
            return (T)MemberwiseClone();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void onPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
