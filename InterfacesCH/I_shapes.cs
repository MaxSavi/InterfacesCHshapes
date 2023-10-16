public interface IShape
{
    int Scircle();
    int Srectangle();
    int Striangle();
    int Pcircle();
    int Prectangle();
    int Ptriangle();
}
class A : IShape
{
    int My_x, My_y, My_z, My_r;

    public int x
    {
        set { My_x = value; }
        get { return My_x; }
    }
    public int y
    {
        set { My_y = value; }
        get { return My_y; }
    }
    public int z
    {
        set { My_z = value; }
        get { return My_z; }
    }

    public int r
    {
        set { My_r = value; }
        get { return My_r; }
    }

    public A() { }
    public A(int x, int y, int z, int r)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.r = r;
    }
    public virtual int Scircle()
    {
        return (int)(Math.Pow(r,2) * Math.PI);
    }
    public virtual int Pcircle()
    {
        return (int)(r * 2 * Math.PI);
    }

    public int Srectangle()
    {
        return x*y;
    }
    public int Prectangle()
    {
        return 2* (x + y);
    }

    public int Striangle()
    {
        int p = (z + x + z) / 2;
        return (int)(Math.Sqrt(p*(p-x)*(p-y)*(p-z)));
    }
    public int Ptriangle()
    {
        return (int)((z + x + z) / 2);
    }
    public virtual void rewrite()
    {
        Console.WriteLine("Переменная x: {0}\nПеременная y: {1}\nПеременная z: {2}\nПеременная r: {3}", x, y, z, r);
    }
}
class Program
{
    static void Main()
    {
        A obj1 = new A(x: 10, y: 12, z: 14, r:6);
        obj1.rewrite();
        Console.WriteLine("Площадь круга при радиусе R = {0}: {1}", obj1.r, obj1.Scircle());
        Console.WriteLine("Периметр круга при радиусе R = {0}: {1}", obj1.r, obj1.Pcircle());
        Console.WriteLine("Площадь прямоугольника при сторонах: {0}, {1}: {2}", obj1.x, obj1.y, obj1.Srectangle());
        Console.WriteLine("Периметр прямоугольника при сторонах: {0}, {1}: {2}", obj1.x, obj1.y, obj1.Prectangle());
        Console.WriteLine("Площадь треугольника при стронах x = {0}, y = {1}, z = {2}: {3}", obj1.x, obj1.y, obj1.z, obj1.Striangle());
        Console.WriteLine("Периметр треугольника при стронах x = {0}, y = {1}, z = {2}: {3}", obj1.x, obj1.y, obj1.z, obj1.Ptriangle());

        Console.ReadLine();
    }
}

