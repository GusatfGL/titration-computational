using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.IO;

class Program
{
    static Random rnd = new Random();

    static int width = 256 + 196; // 256 + 196 Perfekta tal, ger dimensionerna av en kortlek
    static int height = 104; // 96 perfekt

    static void Main(string[] args)
    {
        ProduceImg("Initial");
        ProduceImg("Riffle1");
        ProduceImg("Riffle2");
        ProduceImg("Riffle3");
        ProduceImg("Riffle4");
        ProduceImg("Riffle5");
        ProduceImg("Riffle6");
        ProduceImg("Riffle7");
        ProduceImg("Riffle8");
        ProduceImg("Riffle9");
        ProduceImg("Riffle100");
        ProduceImg("Riffle100andWhirlwind");

        Console.WriteLine("Success!");
        Console.ReadKey();
    } 
    static Color GetColor(int cardValue)
    {
        return Color.FromArgb((int)Math.Pow((cardValue - 1), 1.2), (int)Math.Pow(cardValue, 1.4), (int)Math.Pow(cardValue, 0.3)); // x , 127, 14 (nice)
    }

    static void ProduceImg(string name)
    {
        string path = @"C:\Users\gusta\source\repos\binara11111\binara11111\Data\" + name + ".txt";

        var img = new Bitmap(width, height, PixelFormat.Format24bppRgb);
        string[] indexplaces = File.ReadAllLines(path);
        int counter = 0;

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                img.SetPixel(x, y, GetColor(Convert.ToInt32(indexplaces[counter])));
            }
            if (y % 2 == 0 && y != 0)
            {
                counter++;
            }
        }
        img.Save(@"C:\Users\gusta\Desktop\Shuffle Data\" + name + ".png");
        Console.WriteLine($"Sucessfully produced {name} at file path \\..\\Shuffle Data\\{name}.png");
    }

    static int[] RandomizedDeck()
    {
        int[,] cardValues = new int[52, 2];

        for (int i = 0; i < cardValues.GetLength(0); i++)
        {
            cardValues[i, 0] = 1;
            cardValues[i, 1] = rnd.Next();
        }

        int[,] shadow = cardValues.OrderBy();
    }
}
