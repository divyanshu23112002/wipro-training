interface IShape
{
    void Draw();
}

class Circle:IShape
{
    public void Draw()
    {
        Console.WriteLine("Drwaing a Circle");
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