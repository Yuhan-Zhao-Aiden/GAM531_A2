// See https://aka.ms/new-console-template for more information
Console.WriteLine("# Linear Algebra Testing #");
Vector myVec1 = new(1, 2, 3);
Vector myVec2 = new(4, 5, 6);


Console.WriteLine("Add");
Console.WriteLine(myVec1 + myVec2);

Console.WriteLine("Subtract");
Console.WriteLine(myVec1 - myVec2);

Console.WriteLine("Dot");
Console.WriteLine(myVec1 * myVec2);

Console.WriteLine("Cross");
Console.WriteLine(myVec1 / myVec2);



Console.WriteLine("\n======================");

// Matrix
Console.WriteLine("Identity matrix");
Console.WriteLine(Matrix.Id());

Console.WriteLine("Scale matrix (2, 4, 6)");
Console.WriteLine(Matrix.Scale(2, 4, 6));

Console.WriteLine("Rotation matrix to rotate 1 radians on x axis");
Console.WriteLine(Matrix.RotateX(1.0f));

Console.WriteLine("\n======================");
// Matrix & vector operations
Console.WriteLine("Scaling myVec1 by (10, 12, 15)");
Console.WriteLine(Matrix.Scale(10, 12, 15) * myVec1);

Console.WriteLine("Rotate myVec1 by 1 radians along x axis");
Console.WriteLine(Matrix.RotateX(1) * myVec1);
