using System.Numerics;

public class Vector
{
  public float x { get; }
  public float y { get; }
  public float z { get; }


  public Vector(float a, float b, float c)
  {
    x = a; y = b; z = c;
  }

  public static Vector operator +(Vector a, Vector b)
  {
    return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
  }

  public static Vector operator -(Vector a, Vector b)
  {
    return new Vector(a.x - b.x, a.y - b.y, a.z - b.z);
  }

  public static float operator *(Vector a, Vector b)
  {
    return a.x * b.x + a.y * b.y + a.z * b.z;
  }

  public static Vector operator /(Vector a, Vector b)
  {
    return new Vector(
      a.y * b.z - a.z * b.y,
      a.z * b.x - a.x * b.z,
      a.x * b.y - a.y * b.x
    );
  }



  override public String ToString()
  {
    return $"[{x}, {y}, {z}]";
  }
}