using System.Collections.Generic;

namespace CarModel
{
    internal class BexzBuilder : CarBuilder
    {
        private BexzModel bexz = new BexzModel();
        internal override CarDetailModel GetCarModel()
        {
            return this.bexz;
        }

        internal override void SetSequence(List<SequenceType> sequence)
        {
            this.bexz.SetSequence(sequence);
        }
    }
}