using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning3;

class TransmissionError : SystemError
{
    public TransmissionError() : base()
    {

    }

    public override string ErrorMessage()
    {
        return "Växellådsproblem: Reparation krävs!";
    }
}
