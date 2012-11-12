using System.Collections.Generic;
using System.Windows.Input;

using TuneIt.Model;
using TuneIt.ViewModel;

namespace TuneIt.View.Controls
{
    /// <summary>
    /// Interaction logic for TuneView.xaml
    /// </summary>
    public partial class TuneView
    {
        public TuneView()
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

        private void ListBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }
    }
}
