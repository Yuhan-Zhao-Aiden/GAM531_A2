# Linear Algebra Basics

This repository demonstrates some linear algebra operations

## How to Run
1. Clone the repo
```bash
git clone https://github.com/Yuhan-Zhao-Aiden/GAM531_A2.git
cd GAM521_A2
```
2. Run tests
```bash
dotnet run --project LinearAlgebra
```

## Classes
Custom classes for linear algebra operations
### Vector
1. Create
    ```csharp
    Vector v = new Vector(1, 2, 3);
    ```
2. Operations (Add, subtract, dot product, cross product)
    ```csharp
    Vector v1 = new Vector(1, 2, 3);
    Vector v2 = new Vector(4, 5, 6);
    v1 + v2
    v1 - v2
    v1 * v2
    v1 / v2
    ```

### Matrix
1. Create
    ```csharp
    // custom matrix
    Matrix m = new Matrix([
      1, 2, 3,
      4, 5, 6,
      7, 8, 9
    ])

    // Identity matrix
    Matrix id = Matrix.Id();

    // Scale matrix
    Matrix sm = Matrix.Scale(11, 12, 13);

    // Rotate matrix
    Matrix rm = Matrix.RotateX(1);
    ```
2. Access
    ```csharp
    // Access element
    m[1, 2] // m[row, col]

    // Assign
    m[2, 3] = 5
    ```
3. Operation on vector
    ```csharp
    Vector v = new Vector(1, 2, 3);
    Matrix sm = Matrix.Scale(11, 12, 13);
    Matrix rm = Matrix.RotateX(1);

    // scale vec
    sm * v
    // rotate vec
    rm * v
    ```

## Library
No library is used besides MathF for radians calculation


## Test output
```
➜ dotnet run --project .\LinearAlgebra\
# Linear Algebra Testing #
Add
[5, 7, 9]
Subtract
[-3, -3, -3]
Dot
32
Cross
[-3, 6, -3]

======================
Identity matrix
[
  1, 0, 0
  0, 1, 0
  0, 0, 1
]
Scale matrix (2, 4, 6)
[
  2, 0, 0
  0, 4, 0
  0, 0, 6
]
Rotation matrix to rotate 1 radians on x axis
[
  1, 0, 0
  0, 0.5403023, -0.84147096
  0, 0.84147096, 0.5403023
]

======================
Scaling myVec1 by (10, 12, 15)
[10, 24, 45]
Rotate myVec1 by 1 radians along x axis
[1, -1.4438083, 3.3038487]

```