using System.IO;

using TuneIt.Model;

namespace TuneIt.Engine
{
    public class NoteRenderer
    {
        private readonly Note note;
        private readonly Tone tone;

        public NoteRenderer(Note note, Tone tone)
        {
            this.note = note;
            this.tone = tone;
        }

        public void Render(Stream stream)
        {
        }
    }
}
