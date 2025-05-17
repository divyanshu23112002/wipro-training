using System;
public interface ISupportTicket
{
    void CreateTicket(string issue);
    void ResolveTicket(int ticketId);

}
public class EmailSupport:ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine($"Creating ticket via E-mail: {issue}");
    }
    public void ResolveTicket(int ticketId)
    {
        Console.WriteLine($"Resolving ticket {ticketId} vial E-mail");
    }
}
public class PhoneSupport : ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine($"Creating ticket via Phone: {issue}");
    }
    public void ResolveTicket(int ticketId)
    {
        Console.WriteLine($"Resolving ticket {ticketId} vial Phone");
    }
}
class Program
{
    static void Main()
    {
        ISupportTicket ticket;
        ticket= new EmailSupport();
        ticket.CreateTicket("Unable to login to account");
        ticket.ResolveTicket(101);

        Console.WriteLine();

        ticket=new PhoneSupport();
        ticket.CreateTicket("Payment Failed");
        ticket.ResolveTicket(102);
    }
}