using ConsoleTestApp;

EmailDispatcher dispatcher = new EmailDispatcher();

var spamEmail = new { type = "spam" };

dispatcher.Dispatch(spamEmail);

try
{
    dispatcher.Dispatch(spamEmail);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}