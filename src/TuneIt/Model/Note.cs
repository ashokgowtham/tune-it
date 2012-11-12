using System;

namespace TuneIt.Model
{
    public class Note
    {
        private readonly double duration;
        private readonly int noteIndex;

        public Note(double duration, int noteIndex)
        {
            this.duration = duration;
            this.noteIndex = noteIndex;
        }

        /// <summary>
        /// The perceived duration of the note.
        /// </summary>
        public double Duration { get { return duration; } }

        /// <summary>
        /// The number of the note based on frequency.
        /// </summary>
        public int NoteIndex { get { return noteIndex; } }

        /// <summary>
        /// The octave to which this note belongs to.
        /// </summary>
        public int Octave { get { return noteIndex/12; } }

        /// <summary>
        /// The duration of the entire note till it fades out to silence.
        /// </summary>
        public double FadeOutDuration { get { throw new NotImplementedException(); } set { } }

        /// <summary>
        /// Returns a note with increasaed octave.
        /// </summary>
        public Note NextOctave()
        {
            return new Note(duration, noteIndex + 12);
        }

        /// <summary>
        /// Returns a note with decreased octave.
        /// </summary>
        public Note PreviousOctave()
        {
            return new Note(duration, noteIndex - 12);
        }

        /// <summary>
        /// Returns a note with increased frequency.
        /// </summary>
        public Note NextNote()
        {
            return new Note(duration, noteIndex + 1);
        }

        /// <summary>
        /// Returns a note with specified number of notes increase in frequency.
        /// </summary>
        /// <param name="count">Number of notes to advance.</param>
        public Note NextNote(int count)
        {
            return new Note(duration, noteIndex + count);
        }

        /// <summary>
        /// Returns a note with decreased frequency.
        /// </summary>
        public Note PreviousNote()
        {
            return new Note(duration, noteIndex - 1);
        }

        /// <summary>
        /// Returns a note with specified number of notes decrease in frequency.
        /// </summary>
        public Note PreviousNote(int count)
        {
            return new Note(duration, noteIndex - count);
        }
    }
}
