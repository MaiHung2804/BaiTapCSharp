using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

public class Fan
{
    public const int SLOW = 1;
    public const int MEDIUM = 2;
    public const int FAST = 3;

    private int speed = SLOW;
    private bool on = false;
    private double radius = 5;
    private string color = "blue";

    public Fan() { }

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public bool On
    {
        get { return on; }
        set { on = value; }
    }

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    // Phương thức ToString sửa đổi để luôn hiển thị speed
    public override string ToString()
    {
        return $"Speed: {speed}, Color: {color}, Radius: {radius} - fan is {(on ? "on" : "off")}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Fan fan1 = new Fan
        {
            Speed = Fan.FAST,
            Radius = 10,
            Color = "yellow",
            On = true
        };

        Fan fan2 = new Fan
        {
            Speed = Fan.MEDIUM,
            Radius = 5,
            Color = "blue",
            On = false
        };

        Console.WriteLine("Fan 1: " + fan1.ToString());
        Console.WriteLine("Fan 2: " + fan2.ToString());
    }
}