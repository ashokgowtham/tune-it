using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

using TuneIt.Model;

namespace TuneIt.Util
{
    public class NoteWidthScaleConvertor : IMultiValueConverter
    {
        #region IMultiValueConverter Members

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return ((double) values[0])*20;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    public class NoteToBackgroundColorConvertor : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var note = value as Note;
            if (note == null)
            {
                return Colors.Black;
            }
            Color clr = Colors.Red;
            clr.ScA = 1;
            clr.R = (byte) ((note.NoteIndex)*10);
            return new SolidColorBrush(clr);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
