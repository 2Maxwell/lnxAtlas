using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        string path = @"assets/logos/email/logo_mandant1.png";
        int width = 106;
        int height = 80;

        using (Image original = Image.FromFile(path))
        using (Bitmap resized = new Bitmap(original, new Size(width, height)))
        {
            resized.Save(path, System.Drawing.Imaging.ImageFormat.Png);
        }

        Console.WriteLine($"Bild erfolgreich auf {width}x{height} Pixel geändert: {path}");
    }
}
