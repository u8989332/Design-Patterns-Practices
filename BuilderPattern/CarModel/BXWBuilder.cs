using System.Collections.Generic;

namespace CarModel
{
    internal class BXWBuilder : CarBuilder
    {
        private BXWModel bxw = new BXWModel();
        internal override CarDetailModel GetCarModel()
        {
            return this.bxw;
        }

        internal override void SetSequence(List<SequenceType> sequence)
        {
            this.bxw.SetSequence(sequence);
        }
    }
}