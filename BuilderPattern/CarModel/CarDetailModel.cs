using System.Collections.Generic;

namespace CarModel
{
    internal abstract class CarDetailModel
    {
        private List<SequenceType> sequence = new List<SequenceType>();
        protected abstract void Start();
        protected abstract void Stop();
        protected abstract void Alarm();
        protected abstract void EngineBoom();
        public void Run()
        {
            foreach(SequenceType sequenceType in sequence)
            {
                switch (sequenceType)
                {
                    case SequenceType.Alarm:
                        this.Alarm();
                        break;
                    case SequenceType.Start:
                        this.Start();
                        break;
                    case SequenceType.Stop:
                        this.Stop();
                        break;
                    case SequenceType.EngineBoom:
                        this.EngineBoom();
                        break;
                    default:
                        throw new System.Exception("No implemented sequence type");
                }
            }
        }

        public void SetSequence(List<SequenceType> sequence)
        {
            this.sequence = sequence;
        }
    }
}