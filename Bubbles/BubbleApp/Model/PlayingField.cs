using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleApp.Model
{
    public class PlayingField
    {
        private Bubble[,] m_Bubbles;

        public PlayingField()
        {
            m_Bubbles = new Bubble[10, 10];
            Reset();
        }

        public Bubble[,] Bubbles { get { return m_Bubbles; } }

        //public int ColumnCount { get { return m_Bubbles.GetLength(0); } }
        //public int RowCount { get { return m_Bubbles.Rank; } }

        internal void Reset()
        {
            for (int line = 0; line < 10; line++)
            {
                for (int column = 0; column < 10; column++)
                {
                    m_Bubbles[line, column] = new Bubble();
                }
            }
        }
    }
}
