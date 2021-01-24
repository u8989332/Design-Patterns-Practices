using System;

namespace ResumeWithDeepCopy
{
    public class WorkExperience : ICloneable
    {
        public string TimeArea { get; set; }
        public string Company { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}