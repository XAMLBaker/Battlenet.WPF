using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Battlenet.Main._Shared.Converters
{
    public class ImagePathToSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string path && !string.IsNullOrEmpty (path))
            {
                try
                {
                    var image = new BitmapImage ();
                    image.BeginInit ();
                    image.UriSource = new Uri ($"pack://application:,,,{path}", UriKind.Absolute);
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.EndInit ();
                    return image;
                }
                catch(Exception ex)
                {
                    return null; // 경로 오류 등 예외 처리
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException (); // 단방향 바인딩이므로 구현할 필요 없음
        }
    }
}
