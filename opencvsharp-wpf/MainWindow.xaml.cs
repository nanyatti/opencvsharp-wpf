using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

using OpenCvSharp;
using OpenCvSharp.Extensions;


namespace opencvsharp_wpf
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
            src = new Mat(@"C:\Users\tsutsumi\Downloads\pepper素材\pepper.jpg");
            imgResult.Source = src.ToWriteableBitmap();
        }

        Mat src;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var src = new Mat(@"C:\Users\tsutsumi\Downloads\pepper素材\pepper.jpg");
            Mat dst = new Mat();
            Cv2.CvtColor(src, dst, ColorConversionCodes.BGRA2GRAY);
            imgResult.Source = dst.ToWriteableBitmap();
        }
    }
}
