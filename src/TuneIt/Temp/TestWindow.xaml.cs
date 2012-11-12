using System.Collections.Generic;
using System.Windows;

using TuneIt.Model;
using TuneIt.ViewModel;

namespace TuneIt.Temp
{
    /// <summary>
    /// Interaction logic for TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow()
        {
            InitializeComponent();
            DataContext = new TuneViewModel {
                Sequence = new NoteSequence {
                    BaseFrequency = 440,
                    Notes = new List<Note> {
                        new Note(1, 0),
                        new Note(1, 1),
                        new Note(1, 4),
                        new Note(1, 5),
                        new Note(1, 7),
                        new Note(1, 8),
                        new Note(1, 11),
                        new Note(2, 12),
                        new Note(1, 12),
                        new Note(1, 11),
                        new Note(1, 8),
                        new Note(1, 7),
                        new Note(1, 5),
                        new Note(1, 4),
                        new Note(1, 1),
                        new Note(2, 0)
                    }
                }
            };

        }
    }
}
