using BubbleApp.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace BubbleApp.ViewModel
{
    public class BubbleViewModel : ViewModelBase
    {
        private Bubble m_Bubble;

        public BubbleViewModel(Bubble bubble)
        {
            m_Bubble = bubble;
            BurstCommand = new RelayCommand(InternalBurst);
        }

        public Color Color
        {
            get { return m_Bubble.Color; }
        }

        public ICommand BurstCommand { get; private set; }

        private void InternalBurst()
        {
            try
            {
                m_Bubble.Burst();

                RaisePropertyChanged("Color");
            }
            catch (Exception ex)
            {
            }
        }
    }
}
