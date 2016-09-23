using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleApp.Model
{
    public class BubbleApplication
    {
        public BubbleApplication()
        {
            this.Name = "Bubbles";
            this.PlayingField = new PlayingField();
        }

        public string Name { get; private set; }

        public PlayingField PlayingField { get; private set; }

        public void StartNewGame()
        {
            PlayingField.Reset();
        }

    }
}
