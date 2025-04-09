using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning3
{
    class EngineFailureError : SystemError
    {
        public EngineFailureError() : base()
        {
        
        }

        public override string ErrorMessage()
        {
            return "Motorfel: Kontrollera motorstatus!";
        }
    }
}
