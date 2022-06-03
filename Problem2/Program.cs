/*
 * In this example, two classes, Cube and Square, implement an abstract class, Shape, and override its abstract Area property. 
 * The program accepts the side as an input and calculates the areas for the square and cube. 
 * It also accepts the area as an input and calculates the corresponding side for the square and cube.
 * */
abstract class Shape
{
    private double area;
    public abstract double Area
    {
        get;
        set;
    }
}

    class Square : Shape
    {

    private double side;
    public double Side { get; set; }

    public override double Area
        {
            get
            {
                return side * side;
            }
            set
            {
                Side = Math.Sqrt(value);
            }
        }

    public Square(double side)
    {
        this.side = side;
    }
}
class Cube : Shape
{
    private double side;
    public double Side { get => side; set => side = value; }

    public override double Area 
    {
        get
        {
            return Side * Side * Side;
        }
        set 
        {
            Side = Math.Cbrt(value); 
        }
       }

    
    public Cube(double side)
    {
        this.Side = side;
    }
}

class TestShapes
{
    public static void Main(String[] args)
    { 

        double side;
        Console.WriteLine("Enter side");
        //double side = Convert.ToDouble(Console.ReadLine());
        Double.TryParse(Console.ReadLine(),out side);
        Square sq = new Square(side);
        Cube cube=new Cube(side);

        
        Console.WriteLine($"Area of square={sq.Area:N4}");
        Console.WriteLine($"Area of cube={cube.Area:N4}");

        double area;
        Console.WriteLine("Enter area");
        //double side = Convert.ToDouble(Console.ReadLine());
        Double.TryParse(Console.ReadLine(), out area); 

        sq.Area = area;
        cube.Area = side;
        Console.WriteLine($"side of square of area {area}={sq.Side:N4}");
        Console.WriteLine($"Side of cube of area {area}={cube.Side:N4}");

    }
   
}

