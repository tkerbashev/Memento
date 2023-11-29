namespace Memento
{
    public sealed class MoveMemento
    {
        public List<Move> Memento { get; private set; }

        internal MoveMemento(List<Move> moves)
        {
            Memento = new List<Move>(moves);
        }
    }
}
