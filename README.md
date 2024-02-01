Task:

Create a class called 'EmailDispatcher' that has a method called 'Dispatch' that accepts an email object and invokes the appropriate handler(s).

You can define the email object. 

To help with this exercise, the email object can have a property specifying the type of the email.
Also, the content of an email object isn't important so you don't have to define any content such
as To, From, Subject, or the email body/message, etc. * 

Write email handlers that will handle the following requirements:

If the email's type is 'spam', then invoke the 'SpamHandler'.
If the email's type is 'fan', then invoke the 'FanHandler'.
If the email's type is 'complaint', then invoke the 'ComplaintHandler'.
If the email's type is 'misc', then invoke the 'MiscHandler'.

Each handler will just write to the console that it's handling the email.*

If the email's type is none of the above, then let the caller know (e.g. exception, log, etc.).

--
To test your code, write a main program that should call your code with specific email types to
verify the correct handler is invoked.
