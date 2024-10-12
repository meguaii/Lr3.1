using System;

public struct Vector
{
    public double x;
    public double y;
    public double z;

    public Vector(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static Vector operator +(Vector a, Vector b)
    {
        return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
    }

    public static double operator *(Vector a, Vector b)
    {
        return a.x * b.x + a.y * b.y + a.z * b.z;
    }

    public static Vector operator *(Vector a, double scalar)
    {
        return new Vector(a.x * scalar, a.y * scalar, a.z * scalar);
    }
    public static Vector operator *(double scalar,Vector a)
    {
        return a * scalar;+-
    }

    public static bool operator ==(Vector a, Vector b)
    {
        return a.Length() == b.Length();
    }

    public static bool operator !=(Vector a, Vector b)
    {
        return !(a == b);
    }

    public static bool operator <(Vector a, Vector b)
    {
        return a.Length() < b.Length();
    }

    public static bool operator >(Vector a, Vector b)
    {
        return a.Length() > b.Length();
    }

    public static bool operator <=(Vector a, Vector b)
    {
        return a.Length() <= b.Length();
    }

    public static bool operator >=(Vector a, Vector b)
    {
        return a.Length() >= b.Length();
    }

    public double Length()
    {
        return Math.Sqrt(x * x + y * y + z * z);
    }

    public override int GetHashCode()
    {
        return Length().GetHashCode();
    }

    public override string ToString()
    {
        return $"({x}, {y}, {z})";
    }
}
class Program
{
    static void Main()
    {
        Vector v1 = new Vector(3, 2, 3);
        Vector v2 = new Vector(4, 5, 6);

        Vector sum = v1 + v2;
        double vecProduct = v1 * v2;
        Vector scaled = v1 * 2;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"skalar_product: {vecProduct}");
        Console.WriteLine($"vector_by_number: {scaled}");

        Console.WriteLine($"Length_is_equal?: {v1 == v2}");
        Console.WriteLine($"Is v1 < v2? {v1 < v2}");
        Console.WriteLine($"Is v1 > v2? {v1 > v2}");
    }
}
