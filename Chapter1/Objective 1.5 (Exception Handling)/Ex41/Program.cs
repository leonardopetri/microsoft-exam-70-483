using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ex41
{
    class Program
    {
        public class CustomException : Exception, ISerializable
        {
            public int CustomProperty { get; private set; }
            
            public CustomException(){}
            public CustomException(string message) : base(message){}
            public CustomException(string message, Exception innerException) : base(message, innerException){}
            public CustomException(int customProperty, string message) : base(message)
            {
                this.CustomProperty = customProperty;
            }

            public CustomException(SerializationInfo info, StreamingContext context)
            {
                this.CustomProperty = (int)info.GetValue("customProperty", typeof(int));
            }

            public new void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("customProperty", this.CustomProperty, typeof(int));
                info.AddValue("message", this.Message, typeof(string));
            }
        }

        static void Main(string[] args)
        {
            try
            {
                throw new CustomException("Teste");
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
