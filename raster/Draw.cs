namespace raster;

using System;
using System.Drawing;
using System.Runtime.Versioning;

public class Draw {

    [SupportedOSPlatform("windows")]
    public void drawing() {

        int width = 200;
        int height = 200;
        Bitmap bitmap = new Bitmap(width, height);
        var path = Path.GetTempPath();

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

        string filePath = "output.png";
        bitmap.Save(path + filePath);

        Console.WriteLine($"Image saved to {filePath}");
    }

}