using System.Collections.Generic;

namespace CarModel
{
    internal abstract class CarBuilder
    {
        internal abstract void SetSequence(List<SequenceType> sequence);
        internal abstract CarDetailModel GetCarModel();
    }
}