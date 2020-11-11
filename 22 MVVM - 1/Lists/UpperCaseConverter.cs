using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Lists {
    public class UpperCaseConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            if (value != null)
                if (parameter != null && parameter.ToString() == "big")
                    return value.ToString().ToUpper();
                else
                    return value.ToString().ToLower();
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            return value;
        }
    }

    public class TransvestitConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            // Werde zum Mann
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            // Werde zur Frau
            return value;
        }
    }

}
