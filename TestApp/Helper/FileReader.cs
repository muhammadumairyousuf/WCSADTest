using Newtonsoft.Json;

using System.IO;
using System.Windows;
using TestApp.Models;

namespace TestApp.Helper
{
    public static class FileReader
    {
        public static List<ShapeData> ReadShapesFromFile(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                List<ShapeData> shapes = JsonConvert.DeserializeObject<List<ShapeData>>(json);
                return shapes!;
            }
            catch (Exception ex)
            {
                // Handle exceptions such as file not found, JSON parsing errors, etc.
                MessageBox.Show($"Error reading JSON file: {ex.Message}");
                return null;
            }
        }

    }
}
