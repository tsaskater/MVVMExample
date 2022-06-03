using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace MVVMTemplate.UI
{
    class ResultToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string result = (string)value;
            int resultValue;
            bool resultIsDigit = int.TryParse(result, out resultValue);
            if (string.IsNullOrEmpty(result) || resultIsDigit)
            {
                return Brushes.LightGreen;
            }
            else
            {
                return Brushes.Red;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
