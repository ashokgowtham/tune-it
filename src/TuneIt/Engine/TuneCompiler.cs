using System;

using TuneIt.Model;

namespace TuneIt.Engine
{
    public class TuneCompiler
    {
        private readonly Note note;
        private readonly Tone tone;

        public TuneCompiler(Note note, Tone tone)
        {
            this.note = note;
            this.tone = tone;
        }

        public CompiledTune Compile()
        {
            throw new NotImplementedException();
        }
    }
}
