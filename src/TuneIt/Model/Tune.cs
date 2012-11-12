using System.Collections.Generic;

namespace TuneIt.Model
{
    public class NoteSequence
    {
        /// <summary>
        /// The sequence of notes.
        /// </summary>
        public List<Note> Notes { get; set; }

        /// <summary>
        /// The frequency of the base note.
        /// </summary>
        public double BaseFrequency { get; set; }

        /// <summary>
        /// The tempo of the tune in BPM.
        /// </summary>
        public int Tempo { get; set; }
    }
}
