using System;

public abstract class Notification
{
    public abstract void Send();
    public void ShowType()
    {
        Console.WriteLine("Sending Notification");
    }
}
public class EmailNotification:Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending Email Notification");
    }
}
public class SMSNotification:Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending SMS Notification");
    }
}
class Program
{
    static void Main()
    {
        Notification email=new EmailNotification();
        Notification sms=new SMSNotification();

        email.ShowType();
        email.Send();

        sms.ShowType();
        sms.Send();
    }
}