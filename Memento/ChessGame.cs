namespace Memento
{
    public class ChessGame
    {
        private List<Move> moves = new();
        private readonly GameProgress _progress;

        public ChessGame(GameProgress progreaa)
        {
            _progress = progreaa;
        }

        public void MakeMove(Colour color, string description)
        {
            Move currentMove = new( color, description );
            moves.Add( currentMove );
            _progress.SetMemento( new MoveMemento( moves ) );
        }

        public void UndoMove()
        {
            var restoredMoves = _progress.UndoMemento();
            if ( restoredMoves != null ) 
            {
                moves = restoredMoves.Memento;
            }
        }

        public void RedoMove()
        {
            var restoreMoves = _progress.RedoMemento();
            if ( restoreMoves != null )
            {
                moves = restoreMoves.Memento;
            }
        }

        public void ListAllMoves()
        {
            foreach (var move in moves)
            {
                Console.WriteLine(move.ToString());
            }
        }
    }
}
