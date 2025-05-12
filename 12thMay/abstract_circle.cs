abstract class Shape
{
    public abstract void Draw();

    public void Display()
    {
        Console.WriteLine("This is a shape");
    }
}
class Circle:Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drwaing a circle");
    }
}
class Program
{
    static void Main()
    {
        Circle c=new Circle();
        c.Draw();
    }
}