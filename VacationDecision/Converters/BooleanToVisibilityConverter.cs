﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace VacationDecision.Converters
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool visibility))
                return null;

            if (visibility)
                return Visibility.Visible;
            else
                return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is Visibility visibility))
                return null;

            if (visibility == Visibility.Visible)
                return true;
            else
                return false;
        }
    }
}
