using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            await DownoladImageAsync(this.Image1, "https://www.google.com/search?q=cat&sxsrf=ALeKk03ErXN_cm0iVhk-UTxl4c1JGRCEyw:1627066208122&source=lnms&tbm=isch&sa=X&ved=2ahUKEwjbnfH67fnxAhUF_qQKHSOPAxcQ_AUoAXoECAEQAw#imgrc=rhaDRoK406Z9TM");
            await DownoladImageAsync(this.Image2, "https://www.google.com/search?q=cat&sxsrf=ALeKk03ErXN_cm0iVhk-UTxl4c1JGRCEyw:1627066208122&source=lnms&tbm=isch&sa=X&ved=2ahUKEwjbnfH67fnxAhUF_qQKHSOPAxcQ_AUoAXoECAEQAw#imgrc=rhaDRoK406Z9TM");
            await DownoladImageAsync(this.Image3, "https://www.google.com/search?q=cat&sxsrf=ALeKk03ErXN_cm0iVhk-UTxl4c1JGRCEyw:1627066208122&source=lnms&tbm=isch&sa=X&ved=2ahUKEwjbnfH67fnxAhUF_qQKHSOPAxcQ_AUoAXoECAEQAw#imgrc=rhaDRoK406Z9TM");
            await DownoladImageAsync(this.Image4, "https://www.google.com/search?q=cat&sxsrf=ALeKk03ErXN_cm0iVhk-UTxl4c1JGRCEyw:1627066208122&source=lnms&tbm=isch&sa=X&ved=2ahUKEwjbnfH67fnxAhUF_qQKHSOPAxcQ_AUoAXoECAEQAw#imgrc=rhaDRoK406Z9TM");
            await DownoladImageAsync(this.Image5, "https://www.google.com/search?q=cat&sxsrf=ALeKk03ErXN_cm0iVhk-UTxl4c1JGRCEyw:1627066208122&source=lnms&tbm=isch&sa=X&ved=2ahUKEwjbnfH67fnxAhUF_qQKHSOPAxcQ_AUoAXoECAEQAw#imgrc=rhaDRoK406Z9TM");
        }

        private async Task DownoladImageAsync(Image image, string url)
        {
            var client = new HttpClient();
            await Task.Run(() => { Thread.Sleep(2000)});
            var request = await client.GetAsync(url);
            var byteData = await request.Content.ReadAsByteArrayAsync();
            image.Source = this.LoadImage(byteData);
        }
        private BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
    }
}
