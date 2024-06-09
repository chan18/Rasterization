namespace raster;

using System;
using System.Drawing;
using System.Runtime.Versioning;

public class Draw : IDisposable {
    public void Dispose()
    {
        
    }

    [SupportedOSPlatform("windows")]
    public void drawing(string path) {

        int width = 200;
        int height = 200;
        Bitmap bitmap = new Bitmap(width, height);

        using (Graphics graphics = Graphics.FromImage(bitmap))
        {
            graphics.Clear(Color.White);

            using (Pen pen = new Pen(Color.Black))
            {
                graphics.DrawRectangle(pen, 50, 50, 100, 100);
            }

            using (Brush brush = new SolidBrush(Color.Blue))
            {
                graphics.FillRectangle(brush, 10, 10, 30, 30);
            }
        }

        string filePath = path + "output.png";
        Console.WriteLine($"file path {filePath}");
        bitmap.Save(filePath);

        Console.WriteLine($"Image saved to {filePath}");
    }

}