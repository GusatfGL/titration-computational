using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace IslandGenerator
{
    class Island
    {
        Random rnd = new Random();

        public int TileSize = 8;
        public int Width = 64;
        public int Height = 64;

        public int[,] Data = new int[64, 64];

        public string Path = @"C:\Users\gusta\Desktop\island1.png";

        public Island(int seed)
        {

        }

        public void Init()
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Data[x, y] = 10;
                }
            }
        }

        public void GiveLife(double fertility)
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if (rnd.NextDouble() < fertility) Data[x, y] = 128;
                }
            }
        }

        public void EvalNeighbours()
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    int temp = 0;

                    if (y > 0 && y < Height -1 && x > 0 && x<Width-1) // fix this shit
                    {
                        for (int rel_y = y - 1; rel_y <= y + 1; rel_y++)
                        {
                            for (int rel_x = x-1; rel_x < x+1; rel_x++)
                            {
                                temp += (int)Math.Floor(Data[rel_x,rel_y] / 4.0); // 8.0 can be a parameter and logarithmic(?)
                            }
                        }
                    }

                    Data[x, y] = temp;
                }
            }
        }

        public Color GetColor(int life)
        {
            //if (life == 64) return Color.White;
            //else return Color.Tomato;
            return Color.FromArgb((int)Math.Floor(life / 2.0), life + 30, 100); // Fix this shit
        }

        public void DisplayIsland()
        {
            var img = new Bitmap(Width * TileSize, Height*TileSize, PixelFormat.Format24bppRgb);

            for (int tileY = 0; tileY < Height; tileY++)
            {
                for (int tileX = 0; tileX < Width; tileX++)
                {
                    for (int y = 0; y < TileSize; y++)
                    {
                        for (int x = 0; x < TileSize; x++)
                        {
                            img.SetPixel(tileX*TileSize + x, tileY*TileSize + y, GetColor(Data[tileX,tileY]));
                        }
                    }
                }
            }

            img.Save(Path);

            Process.Start(Path);
        }

    }
}
