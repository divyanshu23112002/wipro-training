using System;

public abstract class TicketBooking
{
    public void ShowBookingInfo()
    {
        Console.WriteLine("Booking Tickets");
    }
    public abstract void BookTicket(int seat);

}
public class BusBooking:TicketBooking
{
    public override void BookTicket(int seat)
    {
        Console.WriteLine($"Booking {seat} Bus tickets");
    }
}
public class FlightBooking : TicketBooking
{
    public override void BookTicket(int seat)
    {
        Console.WriteLine($"Booking {seat} Flight tickets");
    }
}
class Program
{
    static void Main()
    {
        TicketBooking book;
        book=new BusBooking();
        book.ShowBookingInfo();
        book.BookTicket(5);

        Console.WriteLine();

        book=new FlightBooking();
        book.ShowBookingInfo();
        book.BookTicket(6);
    }
}