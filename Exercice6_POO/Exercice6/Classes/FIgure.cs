using Exercice6;

public abstract class Figure : IDeplacable
{
    public Point Origine { get; set; }

    public Figure(Point origine)
    {
        Origine = origine;
    }

    public void Deplacement(double dx, double dy)
    {
        Origine.PosX += dx;
        Origine.PosY += dy;
    }

    public abstract override string ToString();
}
