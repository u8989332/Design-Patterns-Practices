namespace MementoInStack
{
    public class Originator : OriginatorBase<Position>
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