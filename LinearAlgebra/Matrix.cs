public class MatrixCreationException : Exception
{
  public MatrixCreationException(string msg) : base(msg) { }
}

public class Matrix
{
  public float[] m;

  public Matrix(float[] input)
  {
    if (input.Length != 9)
    {
      throw new MatrixCreationException("The matrix requires 9 floats!");
    }
    m = input;
  }

  public Matrix()
  {
    m = new float[9];
  }

  // Helper function to convert 2d index to 1d index for m
  static int Idx(int row, int col) => row * 3 + col;

  // Access and assign using [] operator
  public float this[int row, int col]
  {
    get => m[Idx(row, col)];
    set => m[Idx(row, col)] = value;
  }

  // Generate an identity matrix
  public static Matrix Id()
  {
    return new Matrix([
      1, 0, 0,
      0, 1, 0,
      0, 0, 1
    ]);
  }

  // Generate a scaling matrix
  public static Matrix Scale(float sx, float sy, float sz)
  {
    Matrix sm = new Matrix();
    sm[0, 0] = sx;
    sm[1, 1] = sy;
    sm[2, 2] = sz;
    return sm;
  }

  // Generate a rotation matrix around x axis
  public static Matrix RotateX(float radians)
  {
    float c = MathF.Cos(radians), s = MathF.Sin(radians);
    Matrix rm = new Matrix();
    rm[0, 0] = 1;
    rm[1, 1] = c;
    rm[1, 2] = -s;
    rm[2, 1] = s;
    rm[2, 2] = c;
    return rm;
  }

  // Multiply matrix with vector (m * v) => v
  public static Vector operator *(Matrix a, Vector b)
  {
    return new Vector(
      a[0, 0] * b.x + a[0, 1] * b.y + a[0, 2] * b.z,
      a[1, 0] * b.x + a[1, 1] * b.y + a[1, 2] * b.z,
      a[2, 0] * b.x + a[2, 1] * b.y + a[2, 2] * b.z
    );
  }



  public override string ToString()
  {
    string result = "[\n  ";
    for (int i = 0; i < m.Length; i++)
    {
      result += m[i];
      if (i == 2 || i == 5) { result += "\n  "; }
      else if (i == 8) { result += "\n]"; }
      else { result += ", "; }
    }
    return result;
  }


}