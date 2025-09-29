using eft_app_guide.Models.Entities;
using eft_app_guide.Models.Extractions;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace eft_app_guide.Views.Converters
{
    public class ImageSourceConverter : IValueConverter
    {
        private BitmapImage? Bitmap<T>(T type, string fileName)
        {
            string path = $"{App.ROOT_ASSET_FOLDER}/{nameof(T)}/{fileName}.png";
            if (!File.Exists(path))
            {
                // log
                return null;
            }

            return new BitmapImage(new(path));
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Map map) return Bitmap(map, map.Name) ?? value;
            else if (value is Trader trader) return Bitmap(trader, trader.Name) ?? value;
            else if (value is Extraction extraction) return Bitmap(extraction, extraction.Name) ?? value;
            else return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
