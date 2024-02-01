using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public class EmailDispatcher
    {

        public void Dispatch(dynamic email) 
        {
            string emailType = email.type;
            switch (emailType)
            {
                case "spam":
                    new SpamHandler().Handle();
                    break;
                case "fan":
                    new FanHandler().Handle();
                    break;
                case "complaint":
                    new ComplaintHandler().Handle();
                    break;
                case "misc":
                    new MiscHandler().Handle();
                    break;
                default:
                    throw new ArgumentException($"Unknown email type: {emailType}");
            }
        }

        class SpamHandler
        {
            public void Handle()
            {
                Console.WriteLine("Handling spam email");
            }
        }

        class FanHandler
        {
            public void Handle()
            {
                Console.WriteLine("Handling fan email");
            }
        }

        class ComplaintHandler
        {
            public void Handle()
            {
                Console.WriteLine("Handling complaint email");
            }
        }

        class MiscHandler
        {
            public void Handle()
            {
                Console.WriteLine("Handling miscellaneous email");
            }
        }
    }

   
}
