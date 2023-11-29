namespace Memento
{
    public class GameProgress
    {
        private Stack<MoveMemento> undoMmementos = new();
        private Stack<MoveMemento> redoMementos = new();
        public void SetMemento(MoveMemento memento)
        {
            undoMmementos.Push(memento);
        }

        public MoveMemento? UndoMemento()
        {
            if (undoMmementos.Count > 0) 
            {
                var lastMemento = undoMmementos.Pop( );
                redoMementos.Push( lastMemento );
                return undoMmementos.Peek();
            }
            else 
            { 
                return null; 
            }
        }

        public MoveMemento? RedoMemento() 
        {
            if (redoMementos.Count > 0) 
            {
                var redoMemento = redoMementos.Pop();
                undoMmementos.Push(redoMemento);
                return redoMemento;
            }
            else
            {
                return null;
            }
        }
    }
}
