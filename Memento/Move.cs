namespace Memento
{
    public struct Move
    {
        public Colour Colour;
        public string Description;

        public Move(Colour colour, string description)
        {
            Colour = colour;
            Description = description;
        }

        public override string ToString() 
        {
            return Colour.ToString() + ": " + Description;
        }
    }
}
