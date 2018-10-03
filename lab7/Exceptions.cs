using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{

    [Serializable]
    public class EmptyBouqetException : Exception
    {
        private string _emptyBouqetName;
        public string EmptyBouqetName
        {
            get
            {
                return _emptyBouqetName;
            }
            set
            {
                _emptyBouqetName = value;
            }
        }

        public EmptyBouqetException() { }

        public EmptyBouqetException(string message) : base(message) { }

        public EmptyBouqetException(string message, Exception inner) : base(message, inner) { }

        protected EmptyBouqetException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }


    public class InvalidPlantException: InvalidCastException
    {
        public InvalidPlantException(string message) : base(message) { }
        public InvalidPlantException() { }
        public InvalidPlantException(string message, Exception inner) : base(message, inner) { }
    }

    public class NegativePriceException : Exception
    {
        public NegativePriceException(string message) : base(message) { }
    }

    
}
