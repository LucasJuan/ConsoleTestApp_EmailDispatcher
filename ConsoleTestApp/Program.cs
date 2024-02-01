using ConsoleTestApp;

EmailDispatcher dispatcher = new EmailDispatcher();

dynamic spamEmail = new { type = "spam" };
dynamic fanEmail = new { type = "fan" };
dynamic complaintEmail = new { type = "complaint" };
dynamic miscEmail = new { type = "misc" };
dynamic unknownEmail = new { type = "unknown" };

dispatcher.Dispatch(spamEmail);
dispatcher.Dispatch(fanEmail);
dispatcher.Dispatch(complaintEmail);
dispatcher.Dispatch(miscEmail);

try
{
    dispatcher.Dispatch(unknownEmail);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}