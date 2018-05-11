public class Rectangle
{
    public Rectangle(double left, double top, double width, double height)
    {
        this.Left = left;
        this.Top = top;
        this.Bottom = top - height;
        this.Right = left + width;
    }

    public double Left { get; private set; }
    public double Top { get; private set; }
    public double Bottom { get; private set; }
    public double Right { get; private set; }
}

