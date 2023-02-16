using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_hw_16._02._2023_structures
{
    public struct RgbColor
    {
        private int red;
        private int green;
        private int blue;

        public RgbColor(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public string ToHex()
        {
            string hexRed = red.ToString("X2");
            string hexGreen = green.ToString("X2");
            string hexBlue = blue.ToString("X2");
            return $"#{hexRed}{hexGreen}{hexBlue}";
        }

        public (double Hue, double Saturation, double Lightness) ToHsl()
        {
            double r = red / 255.0;
            double g = green / 255.0;
            double b = blue / 255.0;
            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));
            double delta = max - min;
            double hue = 0.0;
            if (delta != 0.0)
            {
                if (max == r)
                {
                    hue = ((g - b) / delta) % 6.0;
                }
                else if (max == g)
                {
                    hue = ((b - r) / delta) + 2.0;
                }
                else
                {
                    hue = ((r - g) / delta) + 4.0;
                }
                hue *= 60.0;
                if (hue < 0.0)
                {
                    hue += 360.0;
                }
            }
            double lightness = (max + min) / 2.0;
            double saturation = 0.0;
            if (delta != 0.0)
            {
                saturation = delta / (1.0 - Math.Abs(2.0 * lightness - 1.0));
            }
            return (hue, saturation, lightness);
        }

        public (double Cyan, double Magenta, double Yellow, double Black) ToCmyk()
        {
            double r = red / 255.0;
            double g = green / 255.0;
            double b = blue / 255.0;
            double k = 1.0 - Math.Max(r, Math.Max(g, b));
            double c = (1.0 - r - k) / (1.0 - k);
            double m = (1.0 - g - k) / (1.0 - k);
            double y = (1.0 - b - k) / (1.0 - k);
            return (c, m, y, k);
        }

        public override string ToString()
        {
            return $"RGB ({red}, {green}, {blue})";
        }
    }

}
