using System.Collections.Generic;

namespace BuilderWithAttribute
{
    public class Car
    {
        public IList<string> Log = new List<string>();
        [BuildStep(2)]
        public void AddWheel()
        {
            Log.Add("wheel");
        }

        public void AddEngin()
        {
            Log.Add("engine");
        }

        [BuildStep(1, 2)]
        public void AddBody()
        {
            Log.Add("body");
        }
    }
}
