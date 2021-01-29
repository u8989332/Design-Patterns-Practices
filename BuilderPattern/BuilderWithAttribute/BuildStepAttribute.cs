using System;
using System.Reflection;

namespace BuilderWithAttribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public sealed class BuildStepAttribute : Attribute, IComparable
    {
        private int sequence;
        private int times;
        public BuildStepAttribute(int sequence, int times)
        {
            this.sequence = sequence;
            this.times = times;
        }

        public BuildStepAttribute(int sequence) : this(sequence, 1)
        {

        }

        public MethodInfo Handler{ get; set;}
        public int Sequence 
        {
            get
            {
                return this.sequence;
            }
        }
        
        public int Times 
        {
            get
            {
                return this.times;
            }
        }

        public int CompareTo(object obj)
        {
            if(obj == null || obj.GetType() != typeof(BuildStepAttribute))
            {
                throw new ArgumentException("target");
            }

            return this.sequence - ((BuildStepAttribute)obj).sequence;
        }
    }
}
