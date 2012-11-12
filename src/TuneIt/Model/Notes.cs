namespace TuneIt.Model
{
    public class Notes
    {
        private const double Basefrequency = 523.26;
        private readonly Note sa  = new Note(1, 0);
        private readonly Note re1 = new Note(1, 1);
        private readonly Note re2 = new Note(1, 2);
        private readonly Note ga1 = new Note(1, 3);
        private readonly Note ga2 = new Note(1, 4);
        private readonly Note ma1 = new Note(1, 5);
        private readonly Note ma2 = new Note(1, 6);
        private readonly Note pa  = new Note(1, 7);
        private readonly Note da1 = new Note(1, 8);
        private readonly Note da2 = new Note(1, 9);
        private readonly Note ne1 = new Note(1, 10);
        private readonly Note ne2 = new Note(1, 11);

        public Note Sa { get { return sa; } }
        public Note Re1 { get { return re1; } }
        public Note Re2 { get { return re2; } }
        public Note Ga1 { get { return ga1; } }
        public Note Ga2 { get { return ga2; } }
        public Note Ma1 { get { return ma1; } }
        public Note Ma2 { get { return ma2; } }
        public Note Pa { get { return pa; } }
        public Note Da1 { get { return da1; } }
        public Note Da2 { get { return da2; } }
        public Note Ne1 { get { return ne1; } }
        public Note Ne2 { get { return ne2; } }
    }
}
