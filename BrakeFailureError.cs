using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning3
{
    class BrakeFailureError : SystemError
    {
        public BrakeFailureError() : base()
        {

        }

        public override string ErrorMessage()
        {
            return "Bromsfel: Fordonet är osäkert att köra!";
        }
    }
}
