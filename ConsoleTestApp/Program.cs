using ConsoleTestApp;
using static ConsoleTestApp.EmailDispatcher;

EmailDispatcher dispatcher = new EmailDispatcher();

var spamEmail = new Email("spam");

dispatcher.Dispatch(spamEmail);

try
{
    dispatcher.Dispatch(spamEmail);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}