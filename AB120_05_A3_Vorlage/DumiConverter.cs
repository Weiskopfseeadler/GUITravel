using System;
using System.Diagnostics;
using System.Windows.Data;

namespace AB120_05_A3_Vorlage
{
    public class DumiConverter: IValueConverter
    {
            public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
               // Debugger.Break();
                return value;
            }

            public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                //Debugger.Break();
                return value;
            }
        }
    
    
}