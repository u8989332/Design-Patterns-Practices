using System.Collections.Generic;

namespace CarModel
{
    class Director
    {
        private List<SequenceType> sequence = new List<SequenceType>();
        private BexzBuilder bexzBuilder = new BexzBuilder();
        private BXWBuilder bxwBuilder = new BXWBuilder();
        public BexzModel GetABexzModel()
        {
            this.sequence.Clear();
            this.sequence.Add(SequenceType.Start);
            this.sequence.Add(SequenceType.Stop);
            this.bexzBuilder.SetSequence(this.sequence);
            return (BexzModel)this.bexzBuilder.GetCarModel();
        }

        public BexzModel GetBBexzModel()
        {
            this.sequence.Clear();
            this.sequence.Add(SequenceType.EngineBoom);
            this.sequence.Add(SequenceType.Start);
            this.sequence.Add(SequenceType.Stop);
            this.bexzBuilder.SetSequence(this.sequence);
            return (BexzModel)this.bexzBuilder.GetCarModel();
        }

        public BXWModel GetCBXWModel()
        {
            this.sequence.Clear();
            this.sequence.Add(SequenceType.Alarm);
            this.sequence.Add(SequenceType.Start);
            this.sequence.Add(SequenceType.Stop);
            this.bxwBuilder.SetSequence(this.sequence);
            return (BXWModel)this.bxwBuilder.GetCarModel();
        }

        public BXWModel GetDBXWModel()
        {
            this.sequence.Clear();
            this.sequence.Add(SequenceType.Start);
            this.bxwBuilder.SetSequence(this.sequence);
            return (BXWModel)this.bxwBuilder.GetCarModel();
        }
    }
}
