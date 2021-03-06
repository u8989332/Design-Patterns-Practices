namespace MementoWithGeneric
{
    public class Originator : OriginatorBase<Position, Memento>
    {
        public void UpdateX(int x)
        {
            base.state.X = x;
        }

        public void DecreaseX()
        {
            base.state.X--;
        }

        public void IncreaseY()
        {
            base.state.Y++;
        }

        public Position Current
        {
            get
            {
                return base.state;
            }
        }
    }
}