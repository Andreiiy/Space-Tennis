using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Tennis
{
    class Colors
    {
        public Color Get_Color(int c)
        {

            switch (c)
            {
                case 1: return Color.AliceBlue;
                case 2: return Color.AntiqueWhite;
                case 3: return Color.Aqua;
                case 4: return Color.Aquamarine;
                case 5: return Color.Azure;
                case 6: return Color.Beige;
                case 7: return Color.Bisque;
                case 8: return Color.Black;
                case 9: return Color.BlanchedAlmond;
                case 10: return Color.Blue;
                case 11: return Color.BlueViolet;
                case 12: return Color.Brown;
                case 13: return Color.BurlyWood;
                case 14: return Color.CadetBlue;
                case 15: return Color.Chartreuse;
                case 16: return Color.Chocolate;
                case 17: return Color.Coral;
                case 18: return Color.CornflowerBlue;
                case 19: return Color.Cornsilk;
                case 20: return Color.Crimson;
                case 21: return Color.Cyan;
                case 22: return Color.DarkBlue;
                case 23: return Color.DarkCyan;
                case 24: return Color.DarkGoldenrod;
                case 25: return Color.DarkGray;
                case 26: return Color.DarkGreen;
                case 27: return Color.DarkKhaki;
                case 28: return Color.DarkMagenta;
                case 29: return Color.DarkOliveGreen;
                case 30: return Color.DarkOrange;
                case 31: return Color.DarkOrchid;
                case 32: return Color.DarkRed;
                case 33: return Color.DarkSalmon;
                case 34: return Color.DarkSeaGreen;
                case 35: return Color.DarkSlateBlue;
                case 36: return Color.DarkSlateGray;
                case 37: return Color.DarkTurquoise;
                case 38: return Color.DarkViolet;
                case 39: return Color.DeepPink;
                case 40: return Color.DeepSkyBlue;

                case 41: return Color.DimGray;
                case 42: return Color.DodgerBlue;
                case 43: return Color.Firebrick;
                case 44: return Color.FloralWhite;
                case 45: return Color.ForestGreen;
                case 46: return Color.Fuchsia;
                case 47: return Color.Bisque;
                case 48: return Color.Fuchsia;
                case 49: return Color.Gainsboro;
                case 50: return Color.GhostWhite;
                case 51: return Color.Gold;
                case 52: return Color.Goldenrod;
                case 53: return Color.Gray;
                case 54: return Color.Green;
                case 55: return Color.GreenYellow;
                case 56: return Color.Honeydew;
                case 57: return Color.HotPink;
                case 58: return Color.IndianRed;
                case 59: return Color.Indigo;
                case 60: return Color.Ivory;
                case 61: return Color.Khaki;
                case 62: return Color.Lavender;
                case 63: return Color.DarkCyan;
                case 64: return Color.LavenderBlush;
                case 65: return Color.LawnGreen;
                case 66: return Color.LemonChiffon;
                case 67: return Color.LightBlue;
                case 68: return Color.LightCoral;
                case 69: return Color.LightCyan;
                case 70: return Color.LightGoldenrodYellow;
                case 71: return Color.LightGray;
                case 72: return Color.LightGreen;
                case 73: return Color.LightPink;
                case 74: return Color.LightSalmon;
                case 75: return Color.LightSeaGreen;
                case 76: return Color.LightSkyBlue;
                case 77: return Color.LightSlateGray;
                case 78: return Color.LightSteelBlue;
                case 79: return Color.LightYellow;
                case 80: return Color.Lime;


                case 81: return Color.LimeGreen;
                case 82: return Color.Linen;
                case 83: return Color.Magenta;
                case 84: return Color.Maroon;
                case 85: return Color.MediumAquamarine;
                case 86: return Color.MediumBlue;
                case 87: return Color.MediumOrchid;
                case 88: return Color.MediumPurple;
                case 89: return Color.MediumSeaGreen;
                case 90: return Color.MediumSlateBlue;
                case 91: return Color.MediumSpringGreen;
                case 92: return Color.MediumTurquoise;
                case 93: return Color.MediumVioletRed;
                case 94: return Color.MidnightBlue;
                case 95: return Color.MintCream;
                case 96: return Color.MistyRose;
                case 97: return Color.Moccasin;
                case 98: return Color.NavajoWhite;
                case 99: return Color.Navy;
                case 100: return Color.OldLace;

                case 101: return Color.Olive;
                case 102: return Color.OliveDrab;
                case 103: return Color.Orange;
                case 104: return Color.OrangeRed;
                case 105: return Color.Orchid;
                case 106: return Color.PaleGoldenrod;
                case 107: return Color.PaleGreen;
                case 108: return Color.PaleTurquoise;
                case 109: return Color.PaleVioletRed;
                case 110: return Color.PapayaWhip;
                case 111: return Color.PeachPuff;
                case 112: return Color.Peru;
                case 113: return Color.Pink;
                case 114: return Color.Plum;
                case 115: return Color.PowderBlue;
                case 116: return Color.Purple;
                case 117: return Color.Red;
                case 118: return Color.RosyBrown;
                case 119: return Color.RoyalBlue;
                case 120: return Color.SaddleBrown;

                case 121: return Color.Salmon;
                case 122: return Color.SandyBrown;
                case 123: return Color.SeaGreen;
                case 124: return Color.SeaShell;
                case 125: return Color.Sienna;
                case 126: return Color.Silver;
                case 127: return Color.SkyBlue;
                case 128: return Color.SlateBlue;
                case 129: return Color.SlateGray;
                case 130: return Color.Snow;
                case 131: return Color.SpringGreen;
                case 132: return Color.SteelBlue;
                case 133: return Color.Tan;
                case 134: return Color.Teal;
                case 135: return Color.Thistle;
                case 136: return Color.Tomato;
                case 137: return Color.Transparent;
                case 138: return Color.Turquoise;
                case 139: return Color.Violet;
                case 140: return Color.Wheat;
                case 141: return Color.White;
                case 142: return Color.WhiteSmoke;
                case 143: return Color.Yellow;
                case 144: return Color.YellowGreen;

                default: return Color.Yellow;
            }

        }
    }
}
