using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning3
{
    abstract class SystemError
    {
        public abstract string ErrorMessage();

        static List<SystemError> SystemErrors = new List<SystemError>() { new TransmissionError(), new BrakeFailureError(), new EngineFailureError()} ;

        public static void PrintSystemErrors()
        {
            foreach (SystemError error in SystemErrors)
            {
                Console.WriteLine(error.ErrorMessage());
            }
        }
    }
}
