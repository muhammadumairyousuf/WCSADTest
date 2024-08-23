using System.IO;
using System.Windows;
using System.Windows.Shapes;
using TestApp.Models;
using Newtonsoft.Json;
using Path = System.IO.Path;
using TestApp.Helper;
using System.Windows.Media;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var shapeData= LoadData();
            if(shapeData != null && shapeData.Count > 0)
            {
                foreach (var item in shapeData)
                {
                    dynamic shapeParam = new { type = item.Type, a = item.A, b = item.B, c=item.C, color = item.Color, filled = item.Filled, radius = item.Radius, center=item.Center };
                    ShapeBase shape = ShapeFactory.CreateShape(shapeParam);
                    drawingCanvas.Children.Add(shape.Draw());
                }
              
            }
           // AdjustScaling();
          
        }
        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
           // AdjustScaling();
        }

        //private void AdjustScaling()
        //{
        //    // Get the actual size of the window (the size available for the viewbox)
        //    double actualWidth = this.ActualWidth;
        //    double actualHeight = this.ActualHeight;

        //    // Calculate the scale factor to fit the virtual size within the actual size
        //    double scaleX = actualWidth / 1000;
        //    double scaleY = actualHeight / 1000;
        //    double scale = Math.Min(scaleX, scaleY); // Maintain aspect ratio

        //    // Apply the scale transform
        //  //  viewbox.LayoutTransform = new ScaleTransform(scale, scale);
        //}
        public List<ShapeData> LoadData()
        {
            string relativePath = @"data.json";
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = Directory.GetParent(baseDir)!.Parent!.Parent!.Parent!.FullName;
            string filePath = Path.Combine(projectDir, relativePath).Replace("\\","/");
            if (File.Exists(filePath))
            {
                var shapeData = FileReader.ReadShapesFromFile(filePath);
                return shapeData;
            }
            else
            {
                Console.WriteLine("File not found.");
            }

            return null;
        }
     
    }
}