using BubbleApp.Model;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace BubbleApp.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private BubbleApplication m_Application;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            m_Application = new BubbleApplication();
            m_Application.StartNewGame();
            m_Bubbles = new ObservableCollection<BubbleViewModel>();

            CreateBubbleViewModels();
        }

        private ObservableCollection<BubbleViewModel> m_Bubbles;
        public ObservableCollection<BubbleViewModel> Bubbles
        {
            get { return m_Bubbles; }
        }

        //public int ColumnCount
        //{
        //    get { return m_Application.PlayingField.ColumnCount; }
        //}

        //public int RowCount
        //{
        //    get { return m_Application.PlayingField.RowCount; }
        //}


        private void CreateBubbleViewModels()
        {
            foreach (Bubble bubble in m_Application.PlayingField.Bubbles)
            {
                BubbleViewModel vm = new BubbleViewModel(bubble);
                m_Bubbles.Add(vm);
            }
        }
    }
}