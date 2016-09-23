using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BubbleApp.Model
{
    public class Bubble
    {
        public Bubble()
        {
            this.Color = RandomColorGenerator.GetNext();
        }

        public Color Color { get; private set; }
        public int RowIndex { get; private set; }
        public int ColumnIndex { get; private set; }

        public void Burst()
        {
            this.Color = Colors.Black;
        }
    }


    public static class RandomColorGenerator
    {
        private static Random s_Random = new Random();

        private static Color[] m_AllowedColors = new Color[]
        {
            Colors.LightBlue,
            Colors.LightCyan,
            Colors.LightGreen,
            Colors.LightYellow,
            Colors.LightPink
        };

        public static Color GetNext()
        {
            int index = s_Random.Next(0, m_AllowedColors.Length);
            return m_AllowedColors[index];
        }
    }
}
