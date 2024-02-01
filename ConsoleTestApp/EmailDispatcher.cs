namespace ConsoleTestApp
{
    public class EmailDispatcher
    {

        public void Dispatch(Email email) 
        {
            if (string.IsNullOrEmpty(email.Type))
            {
                Console.WriteLine("Email object is null.");
                return;
            }

            switch (email.Type)
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
                    throw new ArgumentException($"Unknown email type: {email.Type}");
            }
        }

        public class Email
        {
            public string Type { get; set; }
            public Email(string type)
            {
                Type = type;
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
