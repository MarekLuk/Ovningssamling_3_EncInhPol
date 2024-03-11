using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace EncInhPol
{

    //3.2.1 
    //3.2.2
    public abstract class UserError
    {
        public abstract string UEMessage();

    }

    //3.2.3
    //3.2.4

    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }

    }

    //3.2.5
    //3.2.6

    public class TextInputError: UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }
    //3.2.9
    //tre egna klassser
     public class  ExcessInputError: UserError 
        {
        public override string UEMessage()
        {
            return "You tried to use too long input. This fired an error!";
        }
    }

    public class WrongInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use forbbiden symbols. This fired an error!";
        }
    }

    public class TooShortInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use too short input. This fired an error!";
        }
    }


}
